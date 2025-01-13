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
    /// Interaction logic for CanvasWPf.xaml
    /// </summary>
    public partial class CanvasWPf : Window
    {
        private Canvas _canvas = new Canvas();

        private Line _line = new Line();
        private Rectangle _rect = new Rectangle(); 
        private Ellipse _ellipse = new Ellipse();
        private Path _path = new Path();
        private Polygon _polygon = new Polygon();
        private Polyline _polyline = new Polyline();

        public CanvasWPf()
        {
            InitializeComponent();
            MainGrid.Children.Add(_canvas);
            Grid.SetColumn(_canvas, 1);
            _canvas.Background = Brushes.DarkOliveGreen;


            //Line 

            _line.Stroke = Brushes.White;
            _line.StrokeThickness = 5;
            _line.X1 = 0;
            _line.Y1 = 0;
            _line.X2 = 100;
            _line.Y2 = 100;

            Canvas.SetLeft(_line, 100);
            Canvas.SetTop(_line, 100);

            _canvas.Children.Add(_line);

            // Path

            _path.Stroke = Brushes.LightPink;
            _path.StrokeThickness = 5;
            _path.Data = Geometry.Parse("M 105,195 C 105,25 355,350 400,170 H 270");
            _canvas.Children.Add(_path);
        }
    }
}
