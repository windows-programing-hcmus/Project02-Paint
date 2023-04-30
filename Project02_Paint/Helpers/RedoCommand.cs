﻿using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    public class RedoCommand : Command
    {
        public RedoCommand(MainWindow app) : base(app)
        {
        }

        public override bool Execute()
        {
            Command? c = _redoHistory.pop();
            if (c != null)
            {
                saveBackup();
                _undoHistory.push(this);
                _app._drawnShapes = new List<IShapeAbility>(c._backup);
            }
            return false;
        }
    }
}
