using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics
{
    public enum OrderStatus
    {
          PENDING       = 1
        , ONPROGRESS
        , OURFORDELIEVERY
        , DELIVERED
    }

    public class Order
    {
        [Key]
        public long OrderId             { get; set; }

        public Product Product          { get; set; }
        public Customer Customer        { get; set; }

        public DateTime OrderDate       { get; set; }
        public OrderStatus OrderStatus  { get; set; }
    }
}
