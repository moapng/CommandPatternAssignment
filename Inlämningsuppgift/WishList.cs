using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public class WishList
    {
        private string _wish;
        Stack<string> unWishStack = new Stack<string>();
        public List<string> letterToSanta = new List<string>() { "båt", "ps5" };

        public WishList(string wish)
        {
            _wish = wish;
        }

        public void Wish()
        {
            letterToSanta.Add(_wish);
            Console.WriteLine(_wish + " has been added, these are the rest of your wishes");
            PrintLetterToSanta();
        }

        public void UnWish()
        {
            letterToSanta.Remove(_wish);
            
            unWishStack.Push(_wish);
            Console.WriteLine(_wish + " has been removed, these are the wishes you still have left");
            PrintLetterToSanta();
        }

        public void ReWish()
        {
            _wish = unWishStack.Pop();
            Wish();
        }
        public void Submit()
        {
            Console.WriteLine("Sending your letter to santa now!");
            PrintLetterToSanta();
        }
        public void PrintLetterToSanta()
        {
            foreach (string wish in letterToSanta)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
