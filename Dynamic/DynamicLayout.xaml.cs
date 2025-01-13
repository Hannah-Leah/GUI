using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Dynamic
{
    /// <summary>
    /// Interaction logic for DynamicLayout.xaml
    /// </summary>
    public partial class DynamicLayout : Window
    {
        public DynamicLayout()
        {
            InitializeComponent();
            MainGrid.ShowGridLines = true;
            MainGrid.RowDefinitions.Add(new RowDefinition());
            MainGrid.RowDefinitions.Add(new RowDefinition());
            MainGrid.RowDefinitions.Add(new RowDefinition());

            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            MainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            MainGrid.ColumnDefinitions[1].Width = new GridLength(2, GridUnitType.Star);

            Button myButton = new Button();
            myButton.Content = "Hello World"!;
            myButton.Width = 200;
            myButton.Height = 100;
            myButton.Width = double.NaN;
            myButton.Height = double.NaN;
            MainGrid.Children.Add(myButton);
            Grid.SetColumn(myButton, 1);
            Grid.SetRow(myButton, 1);

            myButton.SetValue(Grid.RowProperty, 2);
            myButton.SetValue(Grid.ColumnProperty, 2);

            myButton.Click += MainEvent;

            //Textblock mit Border
            TextBlock myTextBlock = new TextBlock();
            myTextBlock.Text = "Hello World";
            myTextBlock.FontSize = 20;
            Border border = new Border();
            border.BorderBrush = new SolidColorBrush(Colors.Black);
            border.BorderThickness = new Thickness(3);
            border.Margin = new Thickness(3, 3, 3, 3);
            border.Child = myTextBlock;
            MainGrid.Children.Add(border);
            Grid.SetColumn(border, 0); Grid.SetRow(border, 0);
            

        }

        public void MainEvent (Object obj, RoutedEventArgs e)
        {
            Button btn = obj as Button;
            switch(btn.Name)
            {
                case "Hello": break;
            }
            btn.Content = "Clicked!";
        }
    }
}
