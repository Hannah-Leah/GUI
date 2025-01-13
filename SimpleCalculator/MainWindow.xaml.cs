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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double num1;
        double num2; 
        double totalNumber; 

        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddingNumbers(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(numberA.Text);
                num2 = Convert.ToDouble(numberB.Text);
                totalNumber = num1 + num2;
                result.Text = totalNumber.ToString();
            }
            catch
            {
                result.Text = "Invalid input!";
            }
        }
        private void SubtractNumbers(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(numberA.Text);
                num2 = Convert.ToDouble(numberB.Text);
                totalNumber = num1 - num2;
                result.Text = totalNumber.ToString();
            }
            catch
            {
                result.Text = "Invalid Input!";
            }
        }
        private void MultiplyNumbers(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(numberA.Text);
                num2 = Convert.ToDouble(numberB.Text);
                totalNumber = num1 * num2;
                result.Text = totalNumber.ToString();
            }
            catch
            {
                result.Text = "Invalid input!";
            }
        }
        private void DivideNumbers(object sender, RoutedEventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(numberA.Text);
                num2 = Convert.ToDouble(numberB.Text);
                totalNumber = num1 / num2;
                totalNumber = Math.Round(totalNumber, 2);
                result.Text = totalNumber.ToString();
            }
            catch
            {
                result.Text = "Invalid input!";
            }
        }

        private void numberB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (numberB.Text.Equals("0"))
            {

                Btn_Division.IsEnabled = false;

            }
            else
            {
                Btn_Division.IsEnabled = true;
            }
        }
    }
}