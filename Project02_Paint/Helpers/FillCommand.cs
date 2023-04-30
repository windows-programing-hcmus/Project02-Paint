using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    internal class FillCommand : Command
    {
        public FillCommand(MainWindow app) : base(app)
        {
        }

        public override bool Execute()
        {
            if (_app._choosenShape != null)
            {
                saveBackup();
                _app._choosenShape.ChooseBackground(_app._currentColor);
                return true;
            }
            return false;
        }
    }
}
