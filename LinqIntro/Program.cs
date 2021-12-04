using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "123ABC", "Sree", "BSC", 21));
            students.Add(new Student(2, "123ABC", "Bill", "BE", 28));
            students.Add(new Student(5, "123ABC", "Emma", "BSC", 34));
            students.Add(new Student(3, "123ABC", "Max", "BTECH", 31));
            students.Add(new Student(4, "123ABC", "Jane", "BE", 45));
            students.Add(new Student(5, "123ABC", "Kate", "BSC", 34));

            //List<Student> bscStudens = new List<Student>();
            //foreach(var st in students)
            //{
            //    if (st.Age > 21 && st.CourseName.Equals("BSC"))
            //        bscStudens.Add(st);
            //}

            //foreach(var student in bscStudens)
            //{
            //    Console.WriteLine(student);
            //}
            //select * from students where coursename = 'BSC' and age >= 21;
            //select avg(age) from students 
            //select * from students where coursename = 'BSC' and age >= 21 order by name;

            var bscStudents = from s in students
                              where s.CourseName == "BSC" && s.Age >= 21
                              orderby s.Name
                              select s;

            var bscStudents2 = students
                                    .Where(d => d.CourseName == "BSC" && d.Age >= 21)
                                    .OrderBy(d => d.Name);

            foreach (var student in bscStudents2)
                Console.WriteLine(student);

            int studentMaxAge = students.Max(d => d.Age);
            int studentMinAge = students.Min(d => d.Age);

            double studentAvgAge = students.Average(d => d.Age);

            int countOfStudens      = students.Count;
            int countOfBscStudents  = students
                                        .Where(d => d.CourseName.Equals("BSC"))
                                        .Count();

            Console.WriteLine($"Max age : {studentMaxAge} Min Age : {studentMinAge}");

            //select name from students where coursename='BSC'
            var bscStudentNames = students
                                            .Where(d => d.CourseName.Equals("BSC"))
                                            .Select(d => d.Name);

            foreach (var name in bscStudentNames)
                Console.WriteLine(name);

            //select distinct coursename from students
            var distinctCourseNames = students
                                            .Select(d => d.CourseName)
                                            .Distinct();

            foreach (var coursename in distinctCourseNames)
                Console.WriteLine(coursename);

            //Anonyumouns data type
            var hoilday = new { Holiday = "Christmas", Date = "25th DEC 2021" };
            Console.WriteLine(hoilday.Holiday + " " + hoilday.Date);

            //select name, coursename from students
            var studentForCourse = students
                                          .Select(d => new { Name = d.Name, Course = d.CourseName,YearOfBirth = DateTime.Now.Year - d.Age });

            foreach (var s in studentForCourse)
                Console.WriteLine($"{s.Name }  {s.Course} {s.YearOfBirth}");


            var firstStudent = students.First(d => d.CourseName == "BSC");
            Console.WriteLine($"First Student : {firstStudent}");

            var lastStudent = students.Last(d => d.CourseName == "BSC");
            Console.WriteLine($"Last Student : {lastStudent}");

            var firstNoExistStudent = students.FirstOrDefault(d => d.CourseName == "BCA");
            if (firstNoExistStudent == null)
                Console.WriteLine("Student with this condition does not exist");
            else
                Console.WriteLine($"First Student : {firstNoExistStudent}");


            var lastNoExistStudent = students.LastOrDefault(d => d.CourseName == "BCA");
            if (lastNoExistStudent == null)
                Console.WriteLine("Student with this condition does not exist");
            else
                Console.WriteLine($"Last Student : {lastNoExistStudent}");

        }
    }
}
