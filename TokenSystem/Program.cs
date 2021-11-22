using System;
using System.Collections.Generic;

namespace TokenSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Token> tokenQueue = new Queue<Token>();

            string userChoice = "";

            do
            {
                Token token = new Token();

                

                Console.Write("Name : ");
                token.Name = Console.ReadLine();

                Console.Write("Email : ");
                token.Email = Console.ReadLine();

                if (!tokenQueue.Contains(token))
                {
                    tokenQueue.Enqueue(token);
                    Console.WriteLine($"YOUR TOKEN NUMBER IS : {token.TokenNumer}");
                }
                else
                {
                    Console.WriteLine("You are already issued a token");
                }

                Console.WriteLine("----------------------------------------------------");
                Console.Write("Do you want to continue  (Y/N) :");
                userChoice = Console.ReadLine();

            }
            while (userChoice == "Y");

            Console.WriteLine("Using Tokens : ");
            foreach(Token token in tokenQueue)
            {
                Console.WriteLine($"CURRENT TOKEN NUMBER : {token.TokenNumer}");
                Console.ReadLine();
            }
        }
    }
}
