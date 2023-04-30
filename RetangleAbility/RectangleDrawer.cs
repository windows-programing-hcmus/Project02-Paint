using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RectangleAbility
{
    public class IRectanglePainter : IDrawer
    {
        public UIElement Draw(IShapeAbility shape)
        {
            var rectangle = shape as RectangleAbility;

       
            double width = Math.Abs(rectangle.RightBottom.X - rectangle.TopLeft.X);
            double height = Math.Abs(rectangle.RightBottom.Y - rectangle.TopLeft.Y);

            var element = new Rectangle()
            {
                Width = width,
                Height = height,
                StrokeThickness = rectangle.Thickness,
                Stroke = rectangle.Brush,
                StrokeDashArray = rectangle.StrokeDash,
                Fill = rectangle.Background
            };

            if (rectangle.RightBottom.X > rectangle.TopLeft.X && rectangle.RightBottom.Y > rectangle.TopLeft.Y)
            {
                Canvas.SetLeft(element, rectangle.TopLeft.X);
                Canvas.SetTop(element, rectangle.TopLeft.Y);
            }
            else if (rectangle.RightBottom.X < rectangle.TopLeft.X && rectangle.RightBottom.Y > rectangle.TopLeft.Y)
            {
                Canvas.SetLeft(element, rectangle.RightBottom.X);
                Canvas.SetTop(element, rectangle.TopLeft.Y);
            }
            else if (rectangle.RightBottom.X > rectangle.TopLeft.X && rectangle.RightBottom.Y < rectangle.TopLeft.Y)
            {
                Canvas.SetLeft(element, rectangle.TopLeft.X);
                Canvas.SetTop(element, rectangle.RightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(element, rectangle.RightBottom.X);
                Canvas.SetTop(element, rectangle.RightBottom.Y);
            }

            return element;
        }
    }
}
