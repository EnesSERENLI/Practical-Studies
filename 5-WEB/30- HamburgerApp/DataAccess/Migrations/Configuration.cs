namespace DataAccess.Migrations
{
    using DataAccess.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Context.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Hamburgers.Any())
            {
                Hamburger h1 = Hamburger.HamburgerInstance; //Singleton
                h1.Name = "Whooper";
                h1.Price = 25;
                context.Hamburgers.Add(h1);
                context.SaveChanges();
                Hamburger h2 = Hamburger.HamburgerInstance;
                h1.Name = "SteakHouse";
                h1.Price = 35;
                context.Hamburgers.Add(h2);
                context.SaveChanges();
                Hamburger h3 = Hamburger.HamburgerInstance;
                h1.Name = "ChickenBurger";
                h1.Price = 20;                                
                context.Hamburgers.Add(h3);
                context.SaveChanges();
            }

            if (!context.Extras.Any())
            {
                Extra e0 = Extra.ExtraInstance;
                e0.Name = "None";
                e0.Price = 0;
                context.Extras.Add(e0);
                context.SaveChanges();
                Extra e1 = Extra.ExtraInstance;
                e1.Name = "Ketchup";
                e1.Price = 2;
                context.Extras.Add(e1);
                context.SaveChanges();
                Extra e2 = Extra.ExtraInstance;
                e2.Name = "Mayonnaise";
                e2.Price = 2;
                context.Extras.Add(e2);
                context.SaveChanges();
                Extra e3 = Extra.ExtraInstance;
                e3.Name = "G.Mayonnaise";
                e3.Price = 2;
                context.Extras.Add(e3);
                context.SaveChanges();
                Extra e4 = Extra.ExtraInstance;
                e4.Name = "Chaddar";
                e4.Price = 3;
                context.Extras.Add(e4);
                context.SaveChanges();
                Extra e5 = Extra.ExtraInstance;
                e5.Name = "Ranch";
                e5.Price = 3;       
                context.Extras.Add(e5);
                context.SaveChanges();
            }

            if (!context.Dimensions.Any())
            {
                Dimension d1 = new Dimension();
                d1.Size = "Small";
                d1.Price = 0;
                context.Dimensions.Add(d1);
                context.SaveChanges();
                Dimension d2 = new Dimension();
                d2.Size = "Middle";
                d2.Price = 3;
                context.Dimensions.Add(d2);
                context.SaveChanges();
                Dimension d3 = new Dimension();
                d3.Size = "Large";
                d3.Price = 5;
                context.Dimensions.Add(d3);
                context.SaveChanges();
            }
        }
    }
}
