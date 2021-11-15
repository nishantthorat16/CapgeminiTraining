using System;

namespace BoxingandUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue     = 10; //Value type stored in stack

            //System.Object
            object intObject = 10; //Reference type stored in heap
            object message   = "Hello World";
            object tax       = .30F;

            object newobject = intObject;
            newobject = 100;

            object boxedValue = intValue;       // Boxing
            int unboxedValue = (int)intObject;  //Unboxing 

            string[,] marks  = new string[2, 10];
            object[,] marks2 = new object[2, 10];

            marks[0, 0] = "English";
            marks[0, 1] = "50";

            marks2[0, 0] = "English";
            marks2[0, 1] = 50; //Boxing

            marks2[1, 0] = "Mathematics";
            marks2[1, 1] = 80;//Boxing

            int totalMarks = (int)marks2[0, 1] //UnBoxing
                           + (int)marks2[1,1]; //UnBoxing

            Console.WriteLine(totalMarks);
        }

       

    }
}
