using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    internal class PasteCommand : Command
    {
        public PasteCommand(MainWindow app) : base(app)
        {
        }

        public override bool Execute()
        {
            saveBackup();
            if(_app._clipboard != null)
            {
                saveBackup();
                IShapeAbility pasteShape = (IShapeAbility)_app._clipboard.Clone();
                pasteShape.pasteAction(_app._newStartPoint, _app._clipboard);
                _app._drawnShapes.Add(pasteShape);
                return true;
            }
            return false;
        }
    }
}
