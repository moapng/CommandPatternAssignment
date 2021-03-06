﻿using System;
using System.Collections.Generic;

namespace Inlämningsuppgift
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Make a wish!");
            string userInput = Console.ReadLine();
            List<string> letterToSanta = new List<string>();
            var wish = new Wish(userInput, letterToSanta);
            var wishCommand = new WishCommand(wish);
            var reWishCommand = new ReWishCommand(wish);
            var submitCommand = new SubmitCommand(wish);
            var invoker = new Invoker();
            invoker.SetCommand(wishCommand);
            invoker.Execute();

            while (true)
            {


                Console.WriteLine("Would you like to make a (W)ish, (U)nwish your latest wish, (R)ewish something or (S)end your letter ot santa?");
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.W:
                        userInput = Console.ReadLine();
                        wish = new Wish(userInput, letterToSanta);
                        wishCommand = new WishCommand(wish);
                        invoker.SetCommand(wishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.U:
                        invoker.SetCommand(wishCommand);
                        invoker.UnExecute();
                        break;
                    case ConsoleKey.R:
                        if (wish.unWishStack.Count != 0)
                        {
                            reWishCommand = new ReWishCommand(wish);
                            invoker.SetCommand(reWishCommand);
                            invoker.Execute();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("There's nothing to rewish!");
                            break;
                        }
                    case ConsoleKey.S:
                        submitCommand = new SubmitCommand(wish);
                        invoker.SetCommand(submitCommand);
                        invoker.Execute();
                        break;
                }
            }
        }
    }
}
