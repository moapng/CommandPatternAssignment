using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public class WishList
    {
        private string _wish;
        public List<string> letterToSanta = new List<string>();

        public WishList(string wish)
        {
            _wish = wish;
        }

        public void Wish()
        {
            letterToSanta.Add(_wish);
            Console.WriteLine(_wish + "Has been added, these are the rest of your wishes");
            foreach (string wish in letterToSanta)
            {
                Console.WriteLine(wish);
            }
        }
        
        public void UnWish()
        {
            letterToSanta.Remove(_wish);
            Console.WriteLine("These are the wishes you still have left");
            foreach (string wish in letterToSanta)
            {
                Console.WriteLine(wish);
            }
        }

        public void ReWish()
        {

        }
        public void Submit()
        {

        }
    }
}
