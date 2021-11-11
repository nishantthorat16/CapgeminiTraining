using System;


namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            Console.Write("Enter first number : ");
            firstnumber = int.Parse(Console.ReadLine());

            int secondnumber = 0;
            Console.Write("Enter second number : ");
            secondnumber = int.Parse(Console.ReadLine());   

            int sum = firstnumber + secondnumber;

            Console.WriteLine($"Sum of {firstnumber} + {secondnumber} = {sum}");


        }
    }
}
