using System;

namespace EfCoreBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Email = "sreehariis@gmail.com";
            //customer.Name = "Sreehari Aranghat";

            //using(OrderContext dbContext = new OrderContext())
            //{
            //    dbContext.Customers.Add(customer);
            //    dbContext.SaveChanges();
            //}


            using (OrderContext dbContext = new OrderContext())
            {
                foreach (var customer in dbContext.Customers)
                    Console.WriteLine($"{customer.CustomerId} {customer.Name} {customer.Email}");
            }
        }
    }
}
