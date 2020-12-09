using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public abstract class Command
    {
        private WishList receiver;
        public Command(WishList receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Execute();
    }
    public enum CommandOption
    {
        Wish, UnWish, ReWish, Submit
    }
}
