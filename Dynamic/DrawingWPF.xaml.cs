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
    /// Interaction logic for DrawingWPF.xaml
    /// </summary>
    public partial class DrawingWPF : Window {

        /*  Aufgaben:
    *  Zeichen von einem Punkt ohne ziehen
    *  Auswahl von Farben :)
    *  Anzeigen der Pinselgroesse :)
    *  Weitere Tools:
    *  Linie
    *  Rectangle
    *  Ellipse
    *  Circle
    *  Clear Canvas :)
    */

        public double SizeSlider { get; set; } = 5.0;
    private bool _freeHandPaint = false;
        private Point _lastPoint = new Point(-1, -1);
        private Brush _currentColor = Brushes.Green; // default color

        private bool _isErasing = false;
        public DrawingWPF()
        {
            this.DataContext = this;
            InitializeComponent();

            myCanvas.MouseMove += CanvasMouseMove;
            myCanvas.MouseLeftButtonDown += LeftMouseDown;
            myCanvas.MouseLeftButtonUp += LeftMouseUp;
        }

    // Event to switch to Eraser Mode 
    private void EraseButton_Click(object sender, RoutedEventArgs e)
        {
            _isErasing = !_isErasing;
            tbl_Debug.Text = _isErasing ? "Eraser mode" : "Drawing Mode";
        }

        // Event to handle color buttons 

        private void ColorButton_Click(Object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            _currentColor = clickedButton.Background; // set the current color to button'S background
            tbl_Debug.Text = $"Drawing with color: {clickedButton.Background.ToString()}";
        }

        // main event for drawing

        public void CanvasMouseMove(object sender, MouseEventArgs e)
        {
            tbl_Debug.Text = $"X: {e.GetPosition(myCanvas).X.ToString()}" + $"Y: {e.GetPosition(myCanvas).Y.ToString()}";
            
            // Single Shape Variant (Laggy)
          
            /*
            if (_freeHandPaint)
            {
                if (_isErasing) // If erasing, use background color (white)
                {
                    Ellipse point = new Ellipse();
                    point.Height = Double.IsRealNumber(SizeSlider) ? SizeSlider : 1;
                    point.Width = Double.IsRealNumber(SizeSlider) ? SizeSlider : 1;
                    point.Fill = Brushes.White; 

                    double halfSlider = SizeSlider / 2;
                    Canvas.SetLeft(point, e.GetPosition(myCanvas).X - halfSlider);
                    Canvas.SetTop(point, e.GetPosition(myCanvas).Y - halfSlider);
                    myCanvas.Children.Add(point);
                }
                else
                {
                    Ellipse point = new Ellipse();
                    point.Height = Double.IsRealNumber(SizeSlider) ? SizeSlider : 1;
                    point.Width = Double.IsRealNumber(SizeSlider) ? SizeSlider : 1;
                    point.Fill = Brushes.Green;

                    double halfSlider = SizeSlider / 2;
                    Canvas.SetLeft(point, e.GetPosition(myCanvas).X - halfSlider);
                    Canvas.SetTop(point, e.GetPosition(myCanvas).Y - halfSlider);
                    myCanvas.Children.Add(point);
                }
            }

            */


            // Smooth Path Variant

            if (_freeHandPaint)
            {
                Path path = new Path();
                if (_isErasing) //  if erasing, use background color (white)
                {
                    path.Stroke = Brushes.White;
                }

                else
                {
                    path.Stroke = _currentColor; // use the current drawing Color
                }
                path.StrokeThickness = Double.IsRealNumber(SizeSlider) ? SizeSlider : 1;

                // old Coordinate
                if (_lastPoint.Equals(new Point(-1, -1)))
                {
                    _lastPoint = e.GetPosition(myCanvas);
                }
                // drawing the line
                path.Data = Geometry.Parse($"M {_lastPoint.X}, {_lastPoint.Y}" + $"L {e.GetPosition(myCanvas).X}, {e.GetPosition(myCanvas).Y} ");
               
                // saving the new "last point"
                _lastPoint = e.GetPosition(myCanvas);
                myCanvas.Children.Add(path);
            }

        }

        // Event for leftButtonDown
        public void LeftMouseDown(object sender, MouseEventArgs e)
        {
            _freeHandPaint = true;
        }

        // Event for LeftButtonUp

        public void LeftMouseUp(object sender, MouseEventArgs e)
        {
            _freeHandPaint = false;
            _lastPoint = new Point(-1, -1);
        }

        private void ClearCanvasButton_Click(object sender, RoutedEventArgs e)
        {
            // remove all children /drawing elements from the canvas
            myCanvas.Children.Clear();  
        }
    }
}
