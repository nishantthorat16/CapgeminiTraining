using System;
using System.Collections.Generic;

namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string,int>> marks = new Dictionary<int, Dictionary<string, int>>();

            DeliveryCities deliveryCities= new DeliveryCities();
            //List<int> data = new List<int>();
            //data.Add(1);
            //data.Add(2);
            //data.Add(3);

            //foreach(int i in data)
               // Console.WriteLine(i);

            foreach(var city in deliveryCities)
                Console.WriteLine(city);
        }
    }
}
