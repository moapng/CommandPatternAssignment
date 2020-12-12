using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    class WishCommand : Command
    {
        private WishList _wishList;
        public WishCommand(WishList wishList) : base(wishList)
        {
            _wishList = wishList;
        }
        public override void Execute()
        {
            _wishList.Wish();
        }
        public override void UnExecute()
        {
            _wishList.UnWish();
        }
    }
    
    class ReWishCommand : Command
    {
        private WishList _wishList;
        public ReWishCommand(WishList wishList) : base(wishList)
        {
            _wishList = wishList;
        }
        public override void Execute()
        {
            _wishList.ReWish();
        }
        public override void UnExecute()
        {

        }
    }
    class SubmitCommand : Command
    {
        private WishList _wishList;
        public SubmitCommand(WishList wishList) : base(wishList)
        {
            _wishList = wishList;
        }
        public override void Execute()
        {
            _wishList.Submit();
        }
        public override void UnExecute()
        {

        }
    }

}
