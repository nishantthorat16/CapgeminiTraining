using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter your age");
            int employeeAge = int.Parse(Console.ReadLine());

            if (employeeAge >= 18 && employeeAge <= 60) //AND &&, OR ||
                Console.WriteLine("Valid Employement Age");
            else if (employeeAge > 60 && employeeAge <= 65)
                Console.WriteLine("May be we can consider");
            else
                Console.WriteLine("Employee must be atleast 18 years of age");*/

            /*
            Console.Write("Enter a weekday : ");
            string userinput = Console.ReadLine();

            switch(userinput)
            {
                case "Monday"   : 
                case "Tuesday"  : Console.WriteLine("It's a long road to weekend"); break;
                case "Wednesday": Console.WriteLine("Almost half way to weekend"); break;
                case "Thursday" : Console.WriteLine("One day to go"); break;
                case "Friday"   : Console.WriteLine("Its weekend"); break;
                case "Saturday" : Console.WriteLine("Time to get some rest"); break;
                case "Sunday"   : Console.WriteLine("No, Its not sunday"); break;
                default         : Console.WriteLine("Does not seem like a weekday");break;
            }*/

            int employeeAge = 18;

            //if (employeeAge >= 18)
            //    Console.WriteLine("Valid Age");
            //else
            //    Console.WriteLine("Invalid Age");

            //Condition ? If True : If False;
            string message = employeeAge >= 18 ? "Valid Age" : "Invalid Age";
            Console.WriteLine(message);

        }
    }
}
