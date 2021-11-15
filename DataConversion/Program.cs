using System;

namespace DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your fav number : ");
            var userInput = Console.ReadLine();
            
            float favNumber;

            

            if (float.TryParse(userInput, out favNumber))
                Console.WriteLine($"Thank you for sharing your fav number {favNumber}");
            else
                Console.WriteLine("Invalid number: Please enter a vaid digit");
        }
    }
}
