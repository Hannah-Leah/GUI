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

namespace Dynamic
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

        private void Btn_Layout_Click(object sender, RoutedEventArgs e)
        {
            DynamicLayout window = new DynamicLayout();
            window.Show();
        }

        private void Btn_Canvas_Click(object sender, RoutedEventArgs e)
        {
            CanvasWPf canvasWPF = new CanvasWPf();
            canvasWPF.Show();
        }

        private void Btn_Drawing_Click(object sender, RoutedEventArgs e)
        {
            DrawingWPF drawingWPF = new DrawingWPF();
            drawingWPF.Show();
        }
    }
}