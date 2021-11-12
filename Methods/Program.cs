using System;

namespace Methods
{
    public class Program
    {
        static void Main()
        {
            int x = 10,y = 10;

            int sum         = Add(x, y);
            float floatSum  = Add(10.5F, 15.0F);

            Console.WriteLine($"{floatSum}");
            Add(10.5, 15.0);

            DisplaySum(x, y, sum);

        }

        //return type int
        //Name is Add
        //Parameters a and b
        static int Add(int a,int b)
        {
            Console.WriteLine("Int add");
            return a + b;
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
