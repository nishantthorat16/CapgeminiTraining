using System;

namespace RefAndOut
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var is not a data type
            //var a           = 10; //Implicit typed valiable 
            //var b           = 10.0F;
            //var message     = "Hello World !!!";

            int a = 20;
            int b;
            string password;
            Console.WriteLine($"Inside Main : {a} before method call");
            IncrementNumber(ref a);
            IncrementoOutNumber(out b);

            Console.WriteLine($"Inside Main : {a} after method call");

        }


        /// <summary>
        /// The variable has to be initialized
        /// </summary>
        /// <param name="x"></param>
        static void IncrementNumber(ref int x)
        {
            Console.WriteLine($"Inside Method : {x} before modification");
            x = x * 30;
            Console.WriteLine($"Inside Method : {x} after modification");
        }

        /// <summary>
        /// The valiable does not have to be initialzized
        /// The variable need to be intialized inside the method
        /// </summary>
        /// <param name="x"></param>
        static void IncrementoOutNumber(out int x)
        {
            x = 10;

            Console.WriteLine($"Inside Method : {x} before modification");
            x = x * 200;
            Console.WriteLine($"Inside Method : {x} after modification");
        }
    }
}
