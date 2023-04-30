﻿using MyContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_Paint.Helpers
{
    public abstract class Command
    {
        protected MainWindow _app;
        public List<IShapeAbility> _backup;
        public static CommandHistory _undoHistory = new CommandHistory();
        public static CommandHistory _redoHistory = new CommandHistory();

        public Command(MainWindow app)
        {
            this._app = app;
        }


        public abstract bool Execute();

        public static void executeCommand(Command c)
        {
            if (c.Execute())
            {
                _redoHistory.clear(); 
                _undoHistory.push(c);
            }
        } 

        public void saveBackup()
        {
            _backup = new List<IShapeAbility>();
            foreach (var shape in _app._drawnShapes)
            {
                _backup.Add((IShapeAbility)shape.Clone());
            }
        }
    }
}
