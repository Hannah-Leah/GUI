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

namespace CanvasPractice
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /*
        public void CanvasPanel()
        {

            // canvas 
            Canvas canvasPanel = new Canvas();
            canvasPanel.Background = new SolidColorBrush(Colors.LightCyan);

            // Rectangles

            
            // <Rectangle Stroke="black" StrokeThickness="10" Fill="red" Height="200" Width="200" Canvas.Left="10" Canvas.Top="10"></Rectangle>
           // <Rectangle Fill="green" Stroke="black" StrokeThickness="10" Width="200" Height="200" Canvas.Left="81" Canvas.Top="66" Panel.ZIndex="3"></Rectangle>
           // <Rectangle Fill="Blue" Stroke="black" StrokeThickness="10" Width="200" Height="200" Canvas.Left="38" Canvas.Top="35"></Rectangle>
            
        

            Rectangle redRec = new Rectangle();
            redRec.Stroke = new SolidColorBrush(Colors.Black);  
            redRec.StrokeThickness = 10;
            redRec.Fill = new SolidColorBrush(Colors.Red);
            redRec.Width = 200;
            redRec.Height = 200;

            Rectangle greenRec = new Rectangle();
            greenRec.Stroke = new SolidColorBrush(Colors.Black);
            greenRec.StrokeThickness = 10;
            greenRec.Fill = new SolidColorBrush(Colors.Green);
            greenRec.Width = 200;
            greenRec.Height = 200;

            Rectangle blueRec = new Rectangle();
            blueRec.Stroke = new SolidColorBrush(Colors.Black);
            blueRec.StrokeThickness = 10;
            blueRec.Fill = new SolidColorBrush(Colors.Blue);
            blueRec.Width = 200;
            blueRec.Height = 200;

            // canvas position
            Canvas.SetLeft(redRec, 10);
            Canvas.SetTop(redRec, 10);
            Canvas.SetLeft(blueRec, 38);
            Canvas.SetTop(blueRec, 35);
            Canvas.SetZIndex(greenRec, 3);

            // Add to Canvas
            canvasPanel.Children.Add(redRec);
            canvasPanel.Children.Add(blueRec);  
            canvasPanel.Children.Add(greenRec);

            mainGrid.Children.Add(canvasPanel);
            
        }
    */
    }
}