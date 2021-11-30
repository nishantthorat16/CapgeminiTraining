using System;

namespace ExtentionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello World!!!";
            data.CountWords();
        }
    }

    public static class StringExtention
    {
        public static int CountWords(this string data)
        {
            return data.Split(" ").Length;
        }
    }
}
