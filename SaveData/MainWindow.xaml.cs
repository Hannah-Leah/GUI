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

namespace SaveData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            // wo liegt das File und wie greifen wir drauf zu
        
            FileStream s = new FileStream(@"C:\Users\Hanie\Downloads\ThisIsATest.txt", FileMode.OpenOrCreate, FileAccess.Write);
           
            using (StreamWriter writer = new StreamWriter(s, Encoding.Unicode))
            {
                Console.WriteLine("----------------");
                writer.WriteLine(Tbx_Input.Text);

                // Close() wird von using automatisch ausgeführt 

                // writer.Close();
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            string temp = "";
            FileStream s = new FileStream(@"C:\Users\Hanie\Downloads\ThisIsATest.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(s, Encoding.Unicode))
            {
                string currentInput;
                while ((currentInput = reader.ReadLine()) != null)
                {
                    temp += currentInput;
                }
            }

            Tbl_Output.Text = temp;

        }
    }
}