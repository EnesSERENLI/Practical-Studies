using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Map;

namespace DataAccess.Context
{
    public class EcommerceContext:DbContext
    {
        public EcommerceContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-JOE5KI8\\SQLEXPRESS02;database=ECommerceDB;Trusted_Connection=True;";
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Configurations.Add(new SupplierMap()); // => Configuration'a ekleyebilmek için CoreMap'de EntityTypeConfiguration'ı kalıtım olarak verdik.
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new SubbCategoryMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
