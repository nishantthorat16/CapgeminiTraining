using System;
using System.Threading;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxLoopCount = 0;
            Console.Write("Enter max count : ");
            maxLoopCount = int.Parse(Console.ReadLine());

            //Thread thread1 = new Thread(new ThreadStart(DisplayNumbers));
            Thread thread1 = new Thread(new ParameterizedThreadStart(DisplayNumbers));
            Thread thread2 = new Thread(new ThreadStart(DisplyMessage));

            thread1.Start(maxLoopCount);
            thread2.Start();

            
            //DisplyMessage();
            //DisplayNumbers();
        }

        public static void DisplayNumbers(object totalCount)
        {
            for (int i = 0; i < (int)totalCount; i++)
            {
                Console.WriteLine("THREAD 1: " + i);
                Thread.Sleep(100);
            }
        }

        public static void DisplyMessage()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("THREAD 2 : Downloaing File");
                Thread.Sleep(100);
            }
        }
    }
}
