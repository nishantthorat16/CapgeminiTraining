using System;
using System.Collections.Generic;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type saftey
            //No boxing and unboxing
            List<int> intList       = new List<int>();
            List<string> cityName   = new List<string>();

            intList.Add(21);
            intList.Add(32);
            intList.AddRange(new int[] { 30, 45, 78, 90 });

            cityName.Add("Bangalore");
            cityName.Add("California");
            cityName.AddRange(new string[] { "Washinton DC", "Kolkata", "Trivandrum" });

            intList.Insert(1, 41);
            intList.Remove(2);

            foreach (var i in intList)
                Console.WriteLine(i);

            intList.Reverse();

            Console.WriteLine("After reverse");
            foreach(var i in intList)
                Console.WriteLine(i);



            foreach (var city in cityName)
                Console.WriteLine(city);
        }
    }
}
