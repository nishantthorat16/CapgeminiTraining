using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            { 
                Console.Write("Enter a fav number :");
                string userInput = Console.ReadLine();

                int favNumber = int.Parse(userInput);
                int percentage = 100 / favNumber;
            }
            //Only the first matching catch statement will be 
            //Considered
            catch (FormatException formatException)
            {
                Console.WriteLine("ERROR : Seems like you have given a wrong data");
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine("ERROR : Its a extremely large number");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something really bad went wrong " + exception.Message);
            }
            finally
            {
                Console.WriteLine("Will be executed in any case");
            }

        }
    }
}
