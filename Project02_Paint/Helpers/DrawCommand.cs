using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    internal class DrawCommand : Command
    {
        public DrawCommand(MainWindow app) : base(app)
        {
        }

        public override bool Execute()
        {
            saveBackup(); // save current state before doing anything
            
            // your action here
            _app._drawnShapes.Add((IShapeAbility)_app._preview.Clone());
            
            return true; // this command change the state of canvas so returns true
        }
    }
}
