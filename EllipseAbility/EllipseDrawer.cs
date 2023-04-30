﻿using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace EllipseEntity
{
    public class EllipseDrawer : IDrawer
    {
        public UIElement Draw(IShapeAbility shape)
        {
            var ellipse = shape as EllipseAbility;

            // TODO: chú ý việc đảo lại rightbottom và topleft 
            double width = Math.Abs(ellipse.RightBottom.X - ellipse.TopLeft.X);
            double height = Math.Abs(ellipse.RightBottom.Y - ellipse.TopLeft.Y);

            var element = new Ellipse()
            {
                Width = width,
                Height = height,
                //StrokeThickness = 1,
                //Stroke = new System.Windows.Media.SolidColorBrush(Colors.Red)
                StrokeThickness = ellipse.Thickness,
                Stroke = ellipse.Brush,
                StrokeDashArray = ellipse.StrokeDash,
                Fill = ellipse.Background
            };

            if (ellipse.RightBottom.X > ellipse.TopLeft.X && ellipse.RightBottom.Y > ellipse.TopLeft.Y)
            {
                Canvas.SetLeft(element, ellipse.TopLeft.X);
                Canvas.SetTop(element, ellipse.TopLeft.Y);
            }
            else if (ellipse.RightBottom.X < ellipse.TopLeft.X && ellipse.RightBottom.Y > ellipse.TopLeft.Y)
            {
                Canvas.SetLeft(element, ellipse.RightBottom.X);
                Canvas.SetTop(element, ellipse.TopLeft.Y);
            }
            else if (ellipse.RightBottom.X > ellipse.TopLeft.X && ellipse.RightBottom.Y < ellipse.TopLeft.Y)
            {
                Canvas.SetLeft(element, ellipse.TopLeft.X);
                Canvas.SetTop(element, ellipse.RightBottom.Y);
            }
            else
            {
                Canvas.SetLeft(element, ellipse.RightBottom.X);
                Canvas.SetTop(element, ellipse.RightBottom.Y);
            }

            return element;
        }
    }
}
