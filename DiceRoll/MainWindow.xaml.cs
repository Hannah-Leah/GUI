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

namespace DiceRoll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> diceRolls = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            string diceType = clickedButton.Content.ToString(); // Get the dice type 
            int numberOfDice = int.Parse(txtNumberOfDice.Text); // Get number of dice to roll


            int maxRoll = diceType switch
            {
                "D100" => 100,
                "D20" => 20,
                "D12" => 12,
                "D10" => 10,
                "D8" => 8,
                "D6" => 6,
                "D4" => 4,
                
            };

            // Roll the dice and add to the list
            Random rng = new Random();
            for (int i = 0; i < numberOfDice; i++)
            {
                int rollResult = rng.Next(1, maxRoll + 1); // Roll the die
                string result = $"{diceType}: {rollResult}";
                diceRolls.Add(result);
            }

            // Keep only the last 10 rolls in the list
            if (diceRolls.Count > 10)
            {
                diceRolls.RemoveAt(0); 
            }

            // Update ListBox
            lstRolls.ItemsSource = null; // Reset the list to avoid duplicates
            lstRolls.ItemsSource = diceRolls; // Update with the new list
            txtNumberOfDice.Text = "1"; // Reset the number of dice input
        }

        // Delete the selected roll
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstRolls.SelectedItem != null)
            {
                string selectedRoll = lstRolls.SelectedItem.ToString();
                diceRolls.Remove(selectedRoll); 

                // Update ListBox
                lstRolls.ItemsSource = null;
                lstRolls.ItemsSource = diceRolls; 
            }
        }
    }
}