using CompanyX;
using Y = CompanyY;
using System;


namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BarCodeReader readerx = new BarCodeReader();
            Console.WriteLine(readerx.ReadBarCode("XYZ"));

            Y.BarCodeReader readery = new Y.BarCodeReader();
            Console.WriteLine(readery.ReadBarCode("XYZ"));
        }
    }
}
