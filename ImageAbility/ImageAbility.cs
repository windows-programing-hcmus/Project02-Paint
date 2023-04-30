using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageAbility
{
    public class ImageAbility : IShapeAbility, ICloneable
    {
        public Point TopLeft { get; set; }
        public Point RightBottom { get; set; }

        public float Width;
        public float Height;

        public string Name => "Image";

        public BitmapImage ShapeImage => new BitmapImage(new Uri("Images/insert.png", UriKind.Relative));

        public BitmapImage Image { get; set; }

        public SolidColorBrush Brush { get; set; }
        public SolidColorBrush Background { get; set; }
        public int Thickness { get; set; }
        public DoubleCollection StrokeDash { get; set; }

        
        public void HandleStart(Point point)
        {
            TopLeft = point;
        }
        public void HandleEnd(Point point)
        {
            
        }

        public void ChooseSolidColorBrush(SolidColorBrush brush)
        {
            Brush = brush;
        }
        public void ChooseThickness(int thickness)
        {
            Thickness = thickness;
        }
        public void ChooseDoubleCollection(DoubleCollection dash)
        {
            StrokeDash = dash;
        }

        public void ChooseBackground(SolidColorBrush background)
        {
            Background = background;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
        public bool isHovering(double x, double y)
        {
            return false;
        }

        public void pasteAction(Point startPoint, IShapeAbility shape)
        {
            var element = shape as ImageAbility;

            TopLeft = startPoint;
            
        }


    }
}
