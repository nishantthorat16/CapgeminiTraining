using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }

        public Product(string name, float unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        }

        public Product() { }
    }
}
