using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class Student : IComparable<Student>
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }

        public Student(int rollNumber, string name)
        {
            RollNumber = rollNumber;
            Name = name;
        }

        

        public int CompareTo(Student other)
        {
          //  return Name.CompareTo(other.Name);
            
            if (RollNumber > other.RollNumber)
                return 1;
            else if (RollNumber < other.RollNumber)
                return -1;
            else
                return 0;
        }
    }
}
