using System;

namespace dynamicdatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intData = 1;//Var is a short hand, Implicity typed data int intData =1 ;

            dynamic studentResult;
            float? studentPercentage = 10.1F;
            var studetGrade = "";

            

            Console.Write("Enter the student grade / percentage : ");
            var tempInput = Console.ReadLine();
            float tempPercentage;

            if(float.TryParse(tempInput, out tempPercentage))
            {
                studentResult = tempPercentage;
            }
            else
                studentResult = tempInput;


            if (studentResult is float)
            {
                studentPercentage = studentResult as float?; //Gives the converted value if successful else returns null
                //int maxMarkNeeded = 90 - studentResult;
                Console.WriteLine("You have given marks in percentage");
            }
            else
            {
                studetGrade = studentResult as string;
                Console.WriteLine("You have given Grade");
            }


           
            
        }
    }
}
