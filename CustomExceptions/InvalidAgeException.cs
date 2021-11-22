using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class InvalidAgeException 
        : ApplicationException
    {
        public InvalidAgeException() 
            : base() { }

        public InvalidAgeException(string message) 
            : base(message) { }

        public InvalidAgeException(string message
                                ,Exception innerException) 
                        : base(message, innerException) { }
    }
}
