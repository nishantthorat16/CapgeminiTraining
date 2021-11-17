using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            string bookNamne = "Angels and Demons";
            //string pattern = "^[a-zA-Z]*$";
            //string pattern   = "^[0-9]*$";
            //string pattern     = "^[a-zA-Z0-9@]*$";
            //string pattern = "^[a-z]{5}$";
            //string pattern = "^[a-z]{3,5}$";
            //string pattern   = @"^\d{10}$";
            //string pattern = @"^\d{4}-[a-z]{4}$"; //1234-sree, 5896-abcd
            //string pattern = "";//KA 04 AB 1234
            //string pattern = @"^[a-zA-Z._0-9]{1,50}@[a-zA-Z._-0-9]{1,10}\.[a-zA-Z]{1,3}$"; //sasfd23544.-_23423sdf@ejwkfke_.-.com

            string pattern = "^[a-zA-Z0-9]*$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine($"Matched Data {Regex.Match(name, "[a-zA-Z]*")}");
                Console.WriteLine($"Your name is {name}");
            }
            else
                Console.WriteLine("Invallid Name :  Only alphabets are allowed");
        }
    }
}
