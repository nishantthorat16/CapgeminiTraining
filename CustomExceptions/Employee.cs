using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Employee
    {
        string name = "";
        public string Name {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, "^[A-Za-z]*$"))
                    name = value;
                else
                    throw new InvalidNameException("Invalid Name");
            }
        }

        int age = 0;
        public int Age
        {
            get { return age; }
            set {
                if (value < 18 || value > 60)
                    throw new InvalidAgeException
                        ("Age must be atleast 18 years and less than 60");

               age = value; 
            
            }
        }

      
    }
}
