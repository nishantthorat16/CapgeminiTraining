using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntro
{
    public class Student
    {
        public long AdmissionId { get; set; }
        public string RegisterNumber { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public int Age { get; set; }

        public Student(long admissionId
                    , string registerNumber
                    , string name
                    , string courseName
                    , int age)
        {
            AdmissionId     = admissionId;
            RegisterNumber  = registerNumber;
            Name            = name;
            CourseName      = courseName;
            Age             = age;
        }

        public override string ToString()
        {
            return $"{Name} / AGE : {Age} / AdmissionId : {AdmissionId}";
        }
    }
}
