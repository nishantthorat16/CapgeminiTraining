using System;

namespace Methods
{
    public class Program
    {
        static void Main()
        {
            int x = 10,y = 10;

            int sum         = Add(firstnumber: x
                                 ,thirdnumber: y
                                 ,secondnumber:0);

            Add(x,y,0);
                                
                                 

            float floatSum  = Add(10.5F, 15.0F);

            Console.WriteLine($"{floatSum}");
            Add(10.5, 15.0);

            Console.WriteLine($"{x} + {y} = {sum}");
            //DisplaySum(x, y, sum);

            WithDrawAmount(withdrawAmount: 100, accountBalance:10000);

        }

        static int WithDrawAmount(int accountBalance,int withdrawAmount)
        {
            return accountBalance - withdrawAmount;
        }

        //return type int
        //Name is Add
        //Parameters a and b
        //B is a optional parameter
        //Optional parametes should always comes after the default parameters
        //Cannot have default parameters after optional parameters
        static int Add(int firstnumber, int secondnumber = 0,int thirdnumber=0)
        {
            Console.WriteLine("Int add");
            return firstnumber + secondnumber + thirdnumber;
        }

        static float Add(float a, float b)
        {
            Console.WriteLine("Float add");
            return a+b;
        }

        static double Add(double a, double b)
        {
            Console.WriteLine("Double add");
            return a + b;
        }

        static void DisplaySum(int x, int y, int sum)
        {
            DisplayDateTime();
            Console.WriteLine($"{x} + {y} = {sum}");
        }

        static void DisplayDateTime()
        {
            Console.WriteLine("Method called at : " + DateTime.Now.ToString());
        }


    }
}
