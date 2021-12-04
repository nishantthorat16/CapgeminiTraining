using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreBasics
{
    public class OrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products   { get; set; }
        public DbSet<Order> Orders       { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Use this format if you are using windows security
            string conStr = "Integrated Security=SSPI;Server=.;DataBase=EfCoreBasics";

            //Use this format if you are using user name and passwword security
            //string conStr = "Integrated Security=False;Server=.;DataBase=EfCoreBasics;uid=sa;password=password";

            optionsBuilder.UseSqlServer(conStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
