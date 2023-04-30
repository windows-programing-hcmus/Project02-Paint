using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LineAbility
{
    public class LineDrawer : IDrawer
    {
        public UIElement Draw(IShapeAbility shape)
        {
            var line = shape as LineAbility;

            var element = new Line()
            {
                X1 = line.Start.X,
                Y1 = line.Start.Y,
                X2 = line.End.X,
                Y2 = line.End.Y,
                StrokeThickness = line.Thickness,
                Stroke = line.Brush,
                StrokeDashArray = line.StrokeDash
            };

            return element;
        }
    }
}
