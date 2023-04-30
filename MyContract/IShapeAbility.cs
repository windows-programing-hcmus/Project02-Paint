using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MyContract
{
    // interface định nghĩa chung cho đối tượng shape
    public interface IShapeAbility : ICloneable
    {
        string Name { get; } // tên của shape đó
        BitmapImage ShapeImage { get; } // icon chứa hình dạng của shape

       
        void ChooseSolidColorBrush(SolidColorBrush brush);// chọn màu đường viền
        void ChooseThickness(int thickness); // chọn kích thước đường viền
        void ChooseDoubleCollection(DoubleCollection dash); // chọn kiểu đường viền
        void ChooseBackground(SolidColorBrush background); // chọn màu nền
        void pasteAction(Point startPoint, IShapeAbility shape);
        void HandleStart(Point point); 
        void HandleEnd(Point point);
        bool isHovering(double x, double y);// kiểm tra xem 1 điểm có nằm giữa shape hay không để fill color
        
    }
}
