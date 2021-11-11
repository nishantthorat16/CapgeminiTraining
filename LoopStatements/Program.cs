using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. While loop
             2. Do While Loop
             3. for loop
             4. foreachloop
             */

            //int abcd = 0; Initializing
            //while(abcd < 10) Condition
            //{
            //    Console.WriteLine(abcd);
            //    abcd = abcd + 1; Increment
            //}

            //int abcd = 0;
            //do
            //{
            //    Console.WriteLine(abcd);
            //    abcd = abcd + 1;
            //} while (abcd < 10);

            //for(int abcd = 0;abcd < 10;abcd += 2)
            //{
            //    Console.WriteLine(abcd);
            //}


            //for (int a = 0; a < 10;)
            //{
            //    Console.WriteLine(a);
            //    a += 2;
            //}

            /*
             * Prime Numbers
            Console.Write("Enter the number :");
            int maxlimit = int.Parse(Console.ReadLine());

            for (int i= 2;i<=maxlimit;i++)
            {
                bool isPrime = true;

                for(int j=2;j<i;j++)
                {
                    if(i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    Console.Write(i + " ");
                }
            }*/

            //Fibnocchi SEries
            Console.Write("Enter the max limit :");
            int maxlimit = int.Parse(Console.ReadLine());

            int firstnumber = 0, secondnumber = 1, sum = 0;
            Console.Write($"{firstnumber} {secondnumber} ");
            for(int i= 2;sum<maxlimit;i++)
            {
                sum = firstnumber + secondnumber;

                if(sum < maxlimit)
                    Console.Write(sum + " ");

                firstnumber  = secondnumber;
                secondnumber = sum;
            }
        }
    }
}
