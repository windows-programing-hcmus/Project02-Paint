using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RectangleAbility
{
    public class RectangleAbility : IShapeAbility, ICloneable
    {
        public Point TopLeft { get; set; }
        public Point RightBottom { get; set; }

        public string Name => "Rectangle";

        public BitmapImage ShapeImage => new BitmapImage(new Uri("Images/rectangle.png", UriKind.Relative));

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
            RightBottom = point;
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
            RectangleAbility cloneShape = (RectangleAbility)this.MemberwiseClone();
            if (Brush != null) cloneShape.Brush = Brush.Clone();
            if (Background != null) cloneShape.Background = Background.Clone();
            if (StrokeDash != null) cloneShape.StrokeDash = StrokeDash.Clone();
            return cloneShape;
        }
        public bool isHovering(double x, double y)
        {
            return Utilities.isPointBetween(x, TopLeft.X, RightBottom.X) && Utilities.isPointBetween(y, TopLeft.Y, RightBottom.Y);
        }

        public void pasteAction(Point startPoint, IShapeAbility shape)
        {
            var element = shape as RectangleAbility;

            TopLeft = startPoint;
            var X = startPoint.X + Math.Abs(element!.RightBottom.X - element.TopLeft.X);
            var Y = startPoint.Y + Math.Abs(element.RightBottom.Y - element.TopLeft.Y);
            Point endPoint = new Point(X, Y);
            RightBottom = endPoint;
        }
    }
}
