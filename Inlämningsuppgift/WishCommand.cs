using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    class WishCommand : Command
    {
        private Wish _wish;
        public WishCommand(Wish wish) : base(wish)
        {
            _wish = wish;
        }
        public override void Execute()
        {
            _wish.MakeAWish();
        }
        public override void UnExecute()
        {
            _wish.UnWish();
        }
    }
    
    class ReWishCommand : Command
    {
        private Wish _wish;
        public ReWishCommand(Wish wish) : base(wish)
        {
            _wish = wish;
        }
        public override void Execute()
        {
            _wish.ReWish();
        }
        public override void UnExecute()
        {

        }
    }
    class SubmitCommand : Command
    {
        private Wish _wish;
        public SubmitCommand(Wish wish) : base(wish)
        {
            _wish = wish;
        }
        public override void Execute()
        {
            _wish.Submit();
        }
        public override void UnExecute()
        {

        }
    }

}
