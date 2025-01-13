using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TESTTTT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Create the main Grid layout
            var mainGrid = new System.Windows.Controls.Grid();

            // Define the columns of the grid
            var column1 = new System.Windows.Controls.ColumnDefinition();
            column1.Width = new System.Windows.GridLength(1, System.Windows.GridUnitType.Star); // Left column
            var column2 = new System.Windows.Controls.ColumnDefinition();
            column2.Width = new System.Windows.GridLength(250); // Right column

            mainGrid.ColumnDefinitions.Add(column1);
            mainGrid.ColumnDefinitions.Add(column2);

            // Left StackPanel (contains TextBlock and ListBox)
            var leftPanel = new System.Windows.Controls.StackPanel();
            leftPanel.Margin = new System.Windows.Thickness(10);

            // Create a basic TextBlock for header
            var headerText = new System.Windows.Controls.TextBlock();
            headerText.Text = "Header";
            headerText.VerticalAlignment = System.Windows.VerticalAlignment.Center;

            // Add TextBlock to left panel
            leftPanel.Children.Add(headerText);

            // Create ListBox (using basic controls)
            var listBox = new System.Windows.Controls.ListBox();
            listBox.Margin = new System.Windows.Thickness(5);
            listBox.Items.Add("Item 1");
            listBox.Items.Add("Item 2");
            listBox.Items.Add("Item 3");

            // Add ListBox to left panel
            leftPanel.Children.Add(listBox);

            // Set left panel to the first column of the grid
            System.Windows.Controls.Grid.SetColumn(leftPanel, 0);
            mainGrid.Children.Add(leftPanel);

            // Right StackPanel (contains three TextBlocks)
            var rightPanel = new System.Windows.Controls.StackPanel();
            rightPanel.Margin = new System.Windows.Thickness(10);
            rightPanel.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            // Create three TextBlocks for the right side
            var textBlock1 = new System.Windows.Controls.TextBlock();
            textBlock1.Text = "TextBlock 1";
            rightPanel.Children.Add(textBlock1);

            var textBlock2 = new System.Windows.Controls.TextBlock();
            textBlock2.Text = "TextBlock 2";
            rightPanel.Children.Add(textBlock2);

            var textBlock3 = new System.Windows.Controls.TextBlock();
            textBlock3.Text = "TextBlock 3";
            rightPanel.Children.Add(textBlock3);

            // Set right panel to the second column of the grid
            System.Windows.Controls.Grid.SetColumn(rightPanel, 1);
            mainGrid.Children.Add(rightPanel);

            // Set the main grid as the content of the window
            this.Content = mainGrid;
        }
    }
}