using System;

namespace DataConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your fav number : ");
            var userInput = Console.ReadLine();

            int favInteger = Convert.ToInt32(userInput); //Work exactly like int.Parse
                                                    
            int favNumber1 = Convert.ToInt32(null); // Convert to 0

            Console.WriteLine($"Conversion : {favNumber1}");
            int favNumber2 = int.Parse(null); //Throw a argument null exception
            //float favNumber;



            //if (float.TryParse(userInput, out favNumber))
            //    Console.WriteLine($"Thank you for sharing your fav number {favNumber}");
            //else
            //    Console.WriteLine("Invalid number: Please enter a vaid digit");
        }

        /// <summary>
        /// Code similar to Convert.Int32
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int MyConvert32(object value)
        {
            if (value == null)
                return 0;
            else
                return int.Parse(value.ToString());

        }
    }
}
