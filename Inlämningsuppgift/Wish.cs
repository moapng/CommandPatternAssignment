using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift
{
    public class Wish
    {
        private string _wish;
        public Stack<string> unWishStack = new Stack<string>();
        public List<string> letterToSanta = new List<string>();

        public Wish(string wish)
        {
            _wish = wish;
        }

        public void MakeAWish()
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
            Console.WriteLine("rewishing latest unwish");
            _wish = unWishStack.Pop();
            MakeAWish();
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
