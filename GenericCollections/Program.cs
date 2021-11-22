using System;
using System.Collections.Generic;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
                Console.WriteLine(city);*/

            //Key has to be unique
            /*
            Dictionary<string, int> marks = new Dictionary<string, int>();

            marks.Add("Maths"   , 70);
            marks.Add("Science" , 80);
            marks.Add("English" , 70);

            //marks.Add("Maths", 83); //Throws an exception
            marks["English"] = 84;

            
          
            foreach (var data in marks)
                Console.WriteLine($"{data.Key} {data.Value}");

            SortedDictionary<string, int> marks = new SortedDictionary<string, int>();

            marks.Add("Maths"  , 70);
            marks.Add("Science", 80);
            marks.Add("English", 70);

            //marks.Add("Maths", 83); //Throws an exception
            marks["English"] = 84;

            foreach (var data in marks)
                Console.WriteLine($"{data.Key} {data.Value}");*/
            /*
            SortedDictionary<Student,int> marks = new SortedDictionary<Student,int>();

            marks.Add(new Student(1010, "Sreehari"), 90);
            marks.Add(new Student(1015, "Arun"), 80);
            marks.Add(new Student(1002, "Bill"), 90);
            marks.Add(new Student(1011, "Yash"), 100);

            foreach (var s in marks)
            {
                Console.WriteLine($"{s.Key.Name} {s.Key.RollNumber}  - MARKS : {s.Value}");
            }*/

            Stack<int> sampleStack = new Stack<int>();
            sampleStack.Push(1);
            sampleStack.Push(2);
            sampleStack.Push(3);
            sampleStack.Push(4);

            Console.WriteLine("Last item in the stack : " + sampleStack.Pop());

            foreach(var t in sampleStack)
                Console.WriteLine(t);


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);   
            queue.Enqueue(4);

            Console.WriteLine("First in the Queue : " + queue.Dequeue());

            foreach(var t in queue)
                Console.WriteLine(t);

        }
    }
}
