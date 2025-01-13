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

namespace EndlessButtons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int buttonCount = 0;  // Track the number of buttons added
        private int MaxColumns = 4;   // Max columns in grid
        private int MaxRows = 4;      // Max rows in grid

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new button
            Button newButton = new Button
            {
                Content = "Button " + (buttonCount + 1),
                Width = 75,
                Height = 30
            };

            // Calculate the row and column based on button count
            int row = buttonCount / MaxColumns;  // Row is the quotient of buttonCount divided by MaxColumns
            int column = buttonCount % MaxColumns;  // Column is the remainder

            // Add the new button to the grid
            MainGrid.Children.Add(newButton);
            Grid.SetRow(newButton, row);
            Grid.SetColumn(newButton, column);

            buttonCount++; // Increment the button count

            // If the grid is full, resize the grid
            if (buttonCount >= MaxColumns * MaxRows)
            {
                ResizeGrid();
            }
        }

        private void ResizeGrid()
        {
            // Increase the number of rows and columns
            MaxColumns += 2;  // Increase number of columns
            MaxRows += 2;     // Increase number of rows

            // Update Grid column and row definitions
            MainGrid.ColumnDefinitions.Clear();
            MainGrid.RowDefinitions.Clear();

            // Add new columns and rows
            for (int i = 0; i < MaxColumns; i++)
            {
                MainGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int i = 0; i < MaxRows; i++)
            {
                MainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
        }
    }
}