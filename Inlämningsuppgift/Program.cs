using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Make a wish!");
            string userInput = Console.ReadLine();
            var wish = new Wish(userInput);
            var wishCommand = new WishCommand(wish);
            var reWishCommand = new ReWishCommand(wish);
            var submitCommand = new SubmitCommand(wish);
            var invoker = new Invoker();
            invoker.SetCommand(wishCommand);
            invoker.Execute();

            while (true)
            {


                Console.WriteLine("Would you like to make a new (W)ish, (U)nwish your latest wish or (R)ewish something?");
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.W:
                        invoker.SetCommand(wishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.U:
                        invoker.SetCommand(wishCommand);
                        invoker.UnExecute();
                        break;
                    case ConsoleKey.R:
                        invoker.SetCommand(reWishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.S:
                        invoker.SetCommand(submitCommand);
                        invoker.Execute();
                        break;
                }
            }
        }
    }
}
