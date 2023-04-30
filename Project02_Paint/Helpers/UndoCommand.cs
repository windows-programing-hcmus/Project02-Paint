using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    public class UndoCommand : Command
    {
        public UndoCommand(MainWindow app) : base(app)
        {
        }

        public override bool Execute()
        {
            Command? c = _undoHistory.pop();
            if (c != null)
            {
                saveBackup();
                _redoHistory.push(this);
                _app._drawnShapes = new List<IShapeAbility>(c._backup);
            }
            return false;
        }
    }
}
