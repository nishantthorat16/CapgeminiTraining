using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numbers
            sbyte sByte = 0;// 8bit signed value
            Console.WriteLine($"SBYTE : Min : {sbyte.MinValue} - Max : {sbyte.MaxValue}");

            byte bytetype = 0;// 8bit unsigned value
            Console.WriteLine($"BYTE :  Min : {byte.MinValue} - Max : {byte.MaxValue}");

            short shorttype = 0;//16 bit signed value
            Console.WriteLine($"SHORT : Min : {short.MinValue} - Max : {short.MaxValue}");

            ushort ushorttype = 0;//16 bit unsigned value
            Console.WriteLine($"USHORT : Min : {ushort.MinValue} - Max : {ushort.MaxValue}");

            int inttype = 0;//32 bit signed value
            Console.WriteLine($"INT : Min : {int.MinValue} - Max : {int.MaxValue}");

            uint uinttype = 0;//32 bit unsigned value
            Console.WriteLine($"UINT : Min : {uint.MinValue} - Max : {uint.MaxValue}");

            long longtype = 0;//64 bit signed value
            Console.WriteLine($"LONG : Min : {long.MinValue} - Max : {long.MaxValue}");

            ulong ulongtype = 0;//64 bit unsigned value
            Console.WriteLine($"ULONG : Min : {ulong.MinValue} - Max : {ulong.MaxValue}");

            //Decimal Places
            float marksPercentage = 100.50F;
            float floatType = 0.0123456789F; //4 bytes 6-9 digits places
            Console.WriteLine($"Float Data : {floatType}");

            double doubleType = 10.01234567890123456789D; //8 byte  15-17 digits 
            Console.WriteLine($"Double Data : {doubleType}");

            decimal decimalType = 10.0123456789012345678901234567890123456789M; //16 byte  28-29 digits 
            Console.WriteLine($"Double Data : {decimalType}");

            bool isEnabled = true;
            isEnabled = false;

            string message  = "Hello World !!!";
            char initial    = 'A';

        }
    }
}
