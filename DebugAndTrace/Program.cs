using System;
using System.Diagnostics;

namespace DebugAndTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.Write("Enter first number :");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number :");
            //int b = int.Parse(Console.ReadLine());

            //if (a > 0 && b > 0)
            //{
            //    int sum = AddNumbers(a, b);
            //    Console.WriteLine($"{a} + {b} = {sum}");
            //}
            //else
            //    Console.WriteLine("Please provide a positive number");
            Trace.Listeners.Add(new TextWriterTraceListener(@"D:\Capgemini Training\Temp\UserActivity.txt"));
            Trace.AutoFlush = true;

            Console.Write("Enter UserName :");
            string username = Console.ReadLine();
            Trace.WriteLine($"TRC : {DateTime.Now} : User Entered username : {username}");
            Debug.WriteLine($"DBG :{DateTime.Now} : User Entered username : {username}");

            Console.Write("Enter Peassword :");
            string password = Console.ReadLine();
            Trace.WriteLine($"TRC :{DateTime.Now} : User Entered Password : {password}");

            if (username == "sree" && password == "paSS1234$$")
            {
                Trace.WriteLine($"TRC : {DateTime.Now} : Authetication success for user {username}");
                Console.WriteLine("Welcome to my application");
            }
            else
            {
                Trace.WriteLine($"TRC :{DateTime.Now} :Login Failed for user {username}");
                Debug.WriteLine($"DBG :{DateTime.Now} : User Entered Password : {password}");
                Console.WriteLine("Login Failed");
            }

        }

        static int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
}
