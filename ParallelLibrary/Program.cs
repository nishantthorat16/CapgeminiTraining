using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers      = Enumerable.Range(0, 20000000); //Fill the numbers with 0 - 20,00,000;

            Stopwatch stopWatchOne = Stopwatch.StartNew();
            var primeNumbers = GetPrimeNumberFromList(numbers.ToList());
            stopWatchOne.Stop();

            Stopwatch stopWatchTwo = Stopwatch.StartNew();
            var primeNumbers2 = GetPrimeNumberFromListInParallel(numbers.ToList());
            stopWatchTwo.Stop();

            Console.WriteLine($"Total Prime Numbes : {primeNumbers.Count} " +
                            $",total time taken : {stopWatchOne.ElapsedMilliseconds}");

            Console.WriteLine($"Total Prime Numbes In Parallel : {primeNumbers2.Count} " +
                            $",total time taken : {stopWatchTwo.ElapsedMilliseconds}");
        }

        public static List<int> GetPrimeNumberFromListInParallel(List<int> numbers)
        {
            var primeNumbers = new ConcurrentBag<int>();
            Parallel.ForEach(numbers, i =>
            {
                bool isPrime = IsPrime(i);
                if(isPrime)
                    primeNumbers.Add(i);
            });

            return primeNumbers.ToList();

        }

            public static List<int> GetPrimeNumberFromList(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();
            foreach(var number in numbers)
            {
                bool isprime = IsPrime(number);
                if(isprime)
                    primeNumbers.Add(number);
            }

            return primeNumbers;
        }

        public static bool IsPrime(int number)
        {
            if(number < 2)
            {
                return true;
            }

            for(int i=2;i<= Math.Sqrt(number);i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
