using DAL.Concrete;
using DAL.Map.EntityMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class EkomProjectContext : DbContext
    {
        public EkomProjectContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-JOE5KI8\\SQLEXPRESS02;database=EkomProjectDb;Trusted_Connection=True;";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<AppUserAndRole> AppUserAndRoles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            //Fluent Api
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserRoleMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());

            modelBuilder.Entity<AppUserAndRole>().HasKey(x => new
            {
                x.AppUserId,
                x.AppUserRoleId
            });
        }
    }
}
