using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSVLoader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> _persons { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            _persons = new ObservableCollection<Person>();
            DataContext = this;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Ensure that SeperatorSelector has a valid selection
            string seperator = string.Empty;

            if (SeperatorSelector.SelectedItem != null)
            {
                seperator = ((ComboBoxItem)SeperatorSelector.SelectedItem).Content.ToString();
            }
            else
            {
                MessageBox.Show("Please select a separator.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Check if the user has entered a custom separator
            if (seperator == "Choose your own")
            {
                // Ensure the user has entered a valid custom separator
                if (string.IsNullOrEmpty(tbxCustomSeparator.Text))
                {
                    MessageBox.Show("Please enter a custom separator.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                seperator = tbxCustomSeparator.Text;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".csv";
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt|All files (*.*)|*.* ";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == true)
            {
               File.WriteAllLines(saveFileDialog.FileName, CSVConvertor.outputCSV(_persons, seperator));
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.Name = tbxName.Text;
            person.LastName = tbxLastName.Text;
            person.Email = tbxEmail.Text;
            person.Birthday = dtpBirthday.SelectedDate == null ? new DateTime() : (DateTime) dtpBirthday.SelectedDate;
            int temp = 0;
            int.TryParse(tbxID.Text, out temp);
            person.ID = temp;

            _persons.Add(person);
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            string seperator = string.Empty;

            if (SeperatorSelector.SelectedItem != null)
            {
                seperator = ((ComboBoxItem)SeperatorSelector.SelectedItem).Content.ToString();
            }
            else
            {
                MessageBox.Show("Please select a separator.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt|All files (*.*)|*.* "; ;
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {


                    foreach (var item in CSVConvertor.ImportCSV(File.ReadAllLines(openFileDialog.FileName), seperator))
                    {
                        _persons.Add(item);
                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong.");
                    return;
                }
                
            }
        }
    }
}