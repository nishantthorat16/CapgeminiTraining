using System;

namespace EfCoreBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Sree", "sreehariis@gmail.com");
            Customer c2 = new Customer("Bill", "bill@gmail.com");
            Customer c3 = new Customer("Mark", "mark@gmail.com");

            Product p1 = new Product("Coffee", 100);
            Product p2 = new Product("Tea", 40);
            Product p3 = new Product("Sugar", 50);
            Product p4 = new Product("Washing Powder", 20);

            OrderContext context = new OrderContext();
            context.Customers.Add(c1);
            context.Customers.Add(c2);
            context.Customers.Add(c3);

            context.Products.AddRange(new [] { p1, p2, p3, p4 });
            context.SaveChanges();

        }
    }
}
