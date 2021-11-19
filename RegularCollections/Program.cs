using System;
using System.Collections;

namespace RegularCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] data = new object[10];
            //Type Saftey : Regular Collection do not have type saftey
            //Everytime you add a value the collection need to do boxing
            //Everytime you take value out the system need to perform unboxing
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add(21);
            arrayList.Add("Sree");
            arrayList.Add(20.5F);

            arrayList.Insert(1, 41);
            foreach (var i in arrayList)
                Console.WriteLine(i);

            Console.WriteLine($"Total Length of Array is : {arrayList.Count}");

           
            arrayList.Add(31);

            Console.WriteLine($"Total Length of Array is : {arrayList.Count}");

            arrayList.Remove(10);
            Console.WriteLine($"Total Length of Array is : {arrayList.Count}");
        }
    }
}
