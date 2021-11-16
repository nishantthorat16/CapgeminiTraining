using MyCalculator;
using System;

namespace UseCalcualtor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = Calculator.Add(20, 30);
            Console.WriteLine(sum);
        }
    }
}
