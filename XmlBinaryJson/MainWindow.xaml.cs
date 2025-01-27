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
using System.Xml.Serialization;

namespace XmlBinaryJson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string _path = @"C:\Users\Hanie\Downloads\helloworld.xml";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

           Person temp = new Person();
            temp.Name = TbxName.Text;
            temp.Email = TbxEmail.Text;
            temp.Taetigkeit = TbxTaetigkeit.Text;

            XmlLoader.WriteToXmlFile<Person>(_path, temp, false);

        }

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSaveAt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}