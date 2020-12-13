using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            while (true)
            {
                Console.WriteLine("Make a wish!");
                string userInput = Console.ReadLine();
                var wish = new Wish(userInput);
                var wishCommand = new WishCommand(wish);
                var reWishCommand = new ReWishCommand(wish);
                var submitCommand = new SubmitCommand(wish);
                var invoker = new Invoker();
                Console.WriteLine("Would you like to make a new wish (1), unwish (2) latest wish, rewish (3) latest unwishing, or send your letter to santa (4)?");
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        userInput = Console.ReadLine();
                        invoker.SetCommand(wishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.D2:
                        invoker.SetCommand(wishCommand);
                        invoker.UnExecute();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("rewishing your latest un-wish");
                        invoker.SetCommand(reWishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.D4:
                        invoker.SetCommand(submitCommand);
                        invoker.Execute();
                        break;
                }
                





            }

        }
    }
}
