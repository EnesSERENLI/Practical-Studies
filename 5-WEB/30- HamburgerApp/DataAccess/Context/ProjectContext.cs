using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataAccess.Entity;

namespace DataAccess.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "server=DESKTOP-JOE5KI8\\SQLEXPRESS02;database=HamburgerDB;Trusted_Connection=true;";
        }
        public DbSet<Hamburger> Hamburgers { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hamburger>().Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Hamburger>().Property(x => x.Price)
                .IsRequired();
            modelBuilder.Entity<Extra>().Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();
            modelBuilder.Entity<Extra>().Property(x => x.Price)
                .IsRequired();
            modelBuilder.Entity<Dimension>().Property(x => x.Size)
               .HasMaxLength(50)
               .IsRequired();
            modelBuilder.Entity<Dimension>().Property(x => x.Price)
                .IsRequired();
            modelBuilder.Entity<Order_Detail>().Property(x => x.ExtraId)
                .IsOptional();
        }
    }
}
