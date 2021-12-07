using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderContext context = new OrderContext();

            /*
            Customer c1 = new Customer("Sree", "sreehariis@gmail.com");
            Customer c2 = new Customer("Bill", "bill@gmail.com");
            Customer c3 = new Customer("Mark", "mark@gmail.com");

            Product p1 = new Product("Coffee", 100);
            Product p2 = new Product("Tea", 40);
            Product p3 = new Product("Sugar", 50);
            Product p4 = new Product("Washing Powder", 20);

           
            context.Customers.Add(c1);
            context.Customers.Add(c2);
            context.Customers.Add(c3);

            context.Products.AddRange(new [] { p1, p2, p3, p4 });
            context.SaveChanges();

            //Update a exising item in the database
            Product product   = context.Products.FirstOrDefault(d => d.ProductId == 1);

            if (product != null)
            {
                product.UnitPrice = 150;

                context.Products.Update(product);
                context.SaveChanges();
            }

            //Delete existing item from database
            Product productToDelete = context.Products.FirstOrDefault(d => d.Name.Equals("Washing Powder"));

            if (productToDelete != null)
            {
                context.Products.Remove(productToDelete);
                context.SaveChanges();
            }

            Customer customer = context.Customers.FirstOrDefault(d => d.Email == "sreehariis@gmail.com");
            Product product   = context.Products.FirstOrDefault(d => d.Name == "Coffee");

            Order order = new Order();
            order.Product = product;
            order.Customer = customer;
            order.OrderDate = DateTime.Now;
            order.OrderStatus = OrderStatus.PENDING;
           
            context.Orders.Add(order);
            context.SaveChanges();*/

            //var orders = context.Orders
            //                    .Include(d => d.Product)
            //                    .Include(d => d.Customer);

            //foreach(var order in orders)
            //{
                
            //    Console.WriteLine($"{order.OrderId} {order.Product.Name} {order.Customer.Name}  {order.OrderStatus}");
            //}

            //var customerOrders = context.Orders.Where(d => d.Customer.CustomerId == 2);
            //foreach(var order in customerOrders)
            //{
            //    order.OrderStatus = OrderStatus.DELIVERED;
            //    context.Orders.Update(order);
            //}

            //context.SaveChanges();

            context.Database.ExecuteSqlRaw("update orders set orderstatus = 4 where customerid = 2");

        }
    }
}
