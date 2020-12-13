using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public abstract class Command
    {
        private Wish receiver;
        public Command(Wish receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Execute();
        public abstract void UnExecute();
    }
    //public enum CommandOption
    //{
    //    Wish, UnWish, ReWish, Submit
    //}
}
