using System;

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //All nullable properties derives from System.Nullable<T>
            //int accouyntBalance;
            //int? initialAccountBalance= null; //Declaring a nullable type
            //float? defaultIntrestRate = null;

            //UpdateBankBaance(ref initialAccountBalance);

            //Console.WriteLine($"Your account is now open with a baance of " +
            //    $"{initialAccountBalance.Value}"); //Use value of nullable type

            //Console.WriteLine(initialAccountBalance.HasValue);

            int?[] marks = new int?[10];

            marks[0] = 54;
            marks[1] = 78;

            var data = 70;
            var data2 = "Test data";
            var data3 = true;

            foreach (var mark in marks)
            {
                if (mark.HasValue)
                    Console.WriteLine(mark);
            }
        }

        static void UpdateBankBaance(ref int? currentBalance)
        {
            if (!currentBalance.HasValue) //currentBalance.HasValue == false Check of a variable is null
            {
                Console.Write("Enter the initial deposit :");
                currentBalance = int.Parse(Console.ReadLine()); //Assign
                                                                //value to nullablle type 
            }

            //currentBalance = currentBalance.HasValue ? currentBalance.Value : int.Parse(Console.ReadLine());
                             //Checkes if currentBalance is null ?? if null use the value
            currentBalance = currentBalance ?? int.Parse(Console.ReadLine());
                
        }

        
    }
}
