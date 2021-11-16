using System;
using System.Text;

namespace StringData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a = a + 10;

            //string stringData = "Hello World, What a wonderful day!!!!";

            //Special Characters
            //stringData = "Hello World,\n What a wonderful\n\n day!!!!";
            //stringData = "Hello World,\tWhat a wonderful\tday!!!!";
            //stringData   = @"c:\myfies\taxreports\myfule.pdf";
            //stringData = "Hello World,What a wonderful\U0001F47Dday!!!!";
            //Console.WriteLine("Hello " + stringData);

            /*
             * string a = "Hello ";
             * a = a + " World !!!";
             */

            /*StringBuilder builder = new StringBuilder();
            builder.Append("Hello ");
            builder.Append("World ");

            Console.WriteLine(builder.ToString());*/

            //string myDriveLocation = @"c:\myfolder";
            //string myDriveName     = @"C:\myfolder";

            //if (myDriveLocation == myDriveName)
            //    Console.WriteLine("Both are same location");
            //else
            //    Console.WriteLine("Both are different");

            //if (myDriveLocation.Equals(myDriveName,StringComparison.OrdinalIgnoreCase))
            //    Console.WriteLine("Both are same location");
            //else
            //    Console.WriteLine("Both are different");

            /*string sampleString = "Hello Word, What a wonder world; and a wonderful day";
            char[] splitCharts = { ',', ';' };
            var splitString = sampleString.Split(splitCharts); //sampleString.Split(',');

            foreach(var s in splitString)
                Console.WriteLine(s);*/

            //string sampleData = "Hello Word, What a wonder world; and a world wonderful day, world";
            //if (sampleData.Contains("earth"))
            //    Console.WriteLine("The string contains world !!!!");
            //else
            //    Console.WriteLine("The string does not contain any world");

            //Console.WriteLine(sampleData.IndexOf("world"));
            //Console.WriteLine(sampleData.LastIndexOf("world"));

            //Console.WriteLine("Total Characters : " + sampleData.Length);
            //Console.WriteLine(sampleData.ToUpper());
            //Console.WriteLine(sampleData.ToLower());
            //Console.WriteLine(sampleData[12]);
            //Console.WriteLine(sampleData.Replace("world", "earth"));
            //Console.WriteLine(sampleData.Substring(12));
            //Console.WriteLine(sampleData.Substring(12, 10));

            Console.Write("Enter your fav quote :");
            string userInput = Console.ReadLine();

            char[] userChars = { ' ', ',', ';' };
            var words        = userInput.Split(userChars);

            string [] distintWords = new string [words.Length];
            int totalDistinctWords = 0;

            //Find the distinct words
            foreach(string word in words)
            {
                bool isCounted = false;
                for(int i = 0; i < distintWords.Length; i++)
                {
                    if(distintWords[i] == word)
                    {
                        isCounted = true;
                        break;
                    }
                } 
                
                if(isCounted == false)
                {
                    distintWords[totalDistinctWords] = word;
                    totalDistinctWords++;
                }
            }

            //Find the occurance of each word
            foreach(string w in distintWords)
            {
                int totalOccurance = 0;
                foreach(var word in words)
                {
                    if(w == word)
                        totalOccurance++;
                }

                Console.WriteLine($"{w} : {totalOccurance}");
            }
        }
    }
}
