using System;

namespace Inlämningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("make a wish bish");
            string userInput = Console.ReadLine();
            var wishList = new WishList(userInput);
            var wishCommand = new WishCommand(wishList);
            var reWishCommand = new ReWishCommand(wishList);
            var submitCommand = new SubmitCommand(wishList);
            var invoker = new Invoker();
            invoker.SetCommand(wishCommand);
            while (true)
            {
                
                
                Console.WriteLine("Would you like to make another wish (1)," +
                    " unwish (2) or rewish (3) something, or send your letter to santa (4)?");
                var choice = Console.ReadKey();
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        invoker.SetCommand(wishCommand);
                        invoker.Execute();
                        break;
                    case ConsoleKey.D2:
                        invoker.SetCommand(wishCommand);
                        invoker.UnExecute();
                        break;
                    case ConsoleKey.D3:
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
