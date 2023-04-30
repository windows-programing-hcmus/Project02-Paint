using System;
using MyContract;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LineAbility
{
    public class LineAbility : IShapeAbility, ICloneable
    {
        public Point Start { get; set; }
        public Point End { get; set; }


        public string Name => "Line";

        public BitmapImage ShapeImage => new BitmapImage(new Uri("Images/line.png", UriKind.Relative));

        public SolidColorBrush Brush { get; set; }
        public int Thickness { get; set; }
        public DoubleCollection StrokeDash { get; set; }

        public object Clone()
        {
            LineAbility cloneShape = (LineAbility)this.MemberwiseClone();
            if (Brush != null) cloneShape.Brush = Brush.Clone();
            if (StrokeDash != null) cloneShape.StrokeDash = StrokeDash.Clone();
            return cloneShape;
        }

        public void HandleEnd(Point point)
        {
            End = point;
        }

        public void HandleStart(Point point)
        {
            Start = point;
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
            // do nothing
        }

        public bool isHovering(double x, double y)
        {
            return Utilities.isPointBetween(x, Start.X, End.X) && Utilities.isPointBetween(y, Start.Y, End.Y);
        }

        public void pasteAction(Point startPoint, IShapeAbility shape)
        {
            var element = shape as LineAbility;

            Start = startPoint;
            var X = startPoint.X + element.End.X - element.Start.X;
            var Y = startPoint.Y + element.End.Y - element.Start.Y;
            Point endPoint = new Point(X, Y);
            End = endPoint;
        }
    }
}
