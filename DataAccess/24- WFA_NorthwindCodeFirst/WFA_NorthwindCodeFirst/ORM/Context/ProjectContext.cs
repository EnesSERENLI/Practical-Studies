using System;
using System.Collections.Generic;
using System.Data.Entity;
using WFA_NorthwindCodeFirst.ORM.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_NorthwindCodeFirst.ORM.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext() // constructor
        {
            Database.Connection.ConnectionString = @"server=DESKTOP-JOE5KI8\SQLEXPRESS02;database=FakeNorthwindDB;Trusted_Connection=True;";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
