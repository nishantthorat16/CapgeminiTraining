using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadLock
{
    public class Program
    {
        static object lockobject = new object();
        static List<int> numbers = new List<int>();
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(new ThreadStart(DisplayInformation));
            //Thread thread2 = new Thread(new ThreadStart(DisplayInformation));

            //thread1.Start();
            //thread2.Start();

            Thread thread1 = new Thread(new ThreadStart(ProcessNumbes));
            Thread thread2 = new Thread(new ThreadStart(ProcessNumbes));

            thread1.Start();
            thread2.Start();
        }

        public static void DisplayInformation()
        {
            lock (lockobject)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} -> {i}");
                }

                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Finished Process");
            }
        }
        

        public static void ProcessNumbes()
        {

            lock (lockobject)
            {
                if (numbers.Count == 0)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(i);
                        numbers.Add(i);
                    }
                }

                if (numbers.Count > 0)
                {
                    int totalSum = 0;
                    foreach (int i in numbers)
                        totalSum += i;

                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} Total Sum is : " + totalSum);
                }
            }


        }


       
    }
}
