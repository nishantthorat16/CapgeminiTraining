using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{CustomerId} / {Name} / {Email}";
        }
    }
}
