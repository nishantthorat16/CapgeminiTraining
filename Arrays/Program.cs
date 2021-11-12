using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Single Dimentional Array
             2. Muti Dimentional Array
             3. Jagged Array
             */

            #region single dimentional array
            /*int[] intArray = new int[10]; //Declared the arry

            intArray[0] = 12; 
            intArray[1] = 21;
            intArray[2] = 100;
            intArray[3] = 35;*/

            //int [] intArray = { 12, 21, 100, 35, 4 };

            //for(int i=0;i<intArray.Length;i++)
            //{
            //    Console.Write(intArray[i] +" ");
            //}

            //foreach (var number in intArray)
            //    Console.Write(number + " ");

            //intArray[2] = 51;
            //Console.WriteLine("\n");
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.Write(intArray[i] + " ");
            //}

            //string [] citynames = { "Bangalore", "Mumbai", "Chennei", "Kolkata" };

            //foreach (var city in citynames)
            //    Console.WriteLine(city);

            #endregion

            #region multi dimentional array
            //int[,] twoDimentionaArray = new int[4,4]
            //{
            //    { 20,35,51,26 },
            //    { 41,45,49,46 },
            //    { 0 ,0 ,0 ,46 },
            //    { 41,0 ,0 ,0 }
            //};

            ///*----------------- Row 1---------------------------*/
            //twoDimentionaArray[0, 0] = 20;
            //twoDimentionaArray[0, 1] = 35;
            //twoDimentionaArray[0, 2] = 51;
            //twoDimentionaArray[0, 3] = 26;

            ///*----------------- Row 2---------------------------*/
            //twoDimentionaArray[1, 0] = 41;
            //twoDimentionaArray[1, 1] = 45;
            //twoDimentionaArray[1, 2] = 49;
            //twoDimentionaArray[1, 3] = 46;

            //for(int row=0; row<4; row++)
            //{
            //    for(int col=0; col<4; col++)
            //        Console.Write(twoDimentionaArray[row, col] + " ");

            //    Console.WriteLine("");

            //}

            #endregion

            #region Jagged Array
            int [][] jaggedArray = new int[3][];
            //jaggedArray[0]       = new int[] { 10, 11, 21, 31, 41 };
            //jaggedArray[1]       = new int[] { 2, 12 };
            //jaggedArray[2]       = new int[] { 3, 4 ,15,17};

            for(int i= 0;i < 3; i++)
            {
                Console.Write("Enter max : ");
                int maxLength  = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[maxLength];

                for(int j=0;j<maxLength;j++)
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }

            Console.Write("----------------------------------------");

            for (int row=0; row<jaggedArray.Length; row++)
            {
                for(int col=0; col<jaggedArray[row].Length; col++)
                    Console.Write(jaggedArray[row][col] + " ");

                Console.WriteLine("");
            }

            #endregion
        }
    }
}
