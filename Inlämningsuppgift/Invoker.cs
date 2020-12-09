using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    class Invoker
    {
        private Command _command;
        public void SetCommand (Command command)
        {
            _command = command;
        }
        public void Execute()
        {
            _command.Execute();
        }
    }
}
