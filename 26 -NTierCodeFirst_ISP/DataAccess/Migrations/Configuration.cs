namespace DataAccess.Migrations
{
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

            if (!context.Categories.Any())
            {
                Category category1 = new Category("Beverages");
                Category category2 = new Category("Condiments");
                Category category3 = new Category("Confections");
                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);
                context.SaveChanges();
            }
            if (!context.Products.Any())
            {
                context.Products.Add(new Product("Chai", 18, 39,1));
                context.Products.Add(new Product("Chang", 19, 17,1));
                context.Products.Add(new Product("Aniseed Syrup", 10, 13,1));
                context.Products.Add(new Product("Chef Anton's Cajun Seasoning", 22, 53,2));
                context.Products.Add(new Product("Chef Anton's Gumbo Mix", 21.35m, 0,2));
                context.Products.Add(new Product("Grandma's Boysenberry Spread", 25, 120,2));
                context.Products.Add(new Product("Genen Shouyu", 15.5m, 39,2));
                context.Products.Add(new Product("Teatime Chocolate Biscuits", 9.2m, 25,3));
                context.Products.Add(new Product("Sir Rodney's Marmalade", 81, 40,3));
                context.Products.Add(new Product("Sir Rodney's Scones", 10, 3,3));
                context.Products.Add(new Product("NuNuCa Nuß-Nougat-Creme", 14, 76,3));
                context.Products.Add(new Product("Sasquatch Ale", 14, 111,1));
                context.SaveChanges();

                
            }
        }
    }
}
