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
    }
    class UnWishCommand : Command
    {
        private WishList _wishList;
        public UnWishCommand(WishList wishList) : base(wishList)
        {
            _wishList = wishList;
        }
        public override void Execute()
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
            _wishList.UnWish();
        }
    }

}
