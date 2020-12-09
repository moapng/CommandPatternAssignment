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

            var invoker = new Invoker();
            invoker.SetCommand(wishCommand);
            Console.WriteLine("nice wish");
            invoker.Execute();

            
        }
    }
}
