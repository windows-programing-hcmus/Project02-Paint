using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyContract
{
    public interface IDrawer
    {
        UIElement Draw(IShapeAbility ability);
    }
}
