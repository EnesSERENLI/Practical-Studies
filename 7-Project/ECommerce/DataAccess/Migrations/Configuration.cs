namespace DataAccess.Migrations
{
    using DataAccess.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.Context.EcommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataAccess.Context.EcommerceContext context)
        {

            //todo: Her bir ürüne ait görseller için UI katman içerisinde content/product isminde klasör oluşturulup içerisine var sayılan görseller eklenecek.
            //Categories
            List<Category> categories = new List<Category>()
            {
                new Category{ID = Guid.NewGuid(),CategoryName="Teknoloji",Description="Teknolojik Ürünler"},
                new Category{ID = Guid.NewGuid(),CategoryName="Giyim",Description="Yazlık kışlık son moda giyim ürünleri"},
                new Category{ID = Guid.NewGuid(),CategoryName="Kitap",Description="Tarih,Edebiyat,Kişisel Gelişim vs..."},
                new Category{ID = Guid.NewGuid(),CategoryName="Kozmetik",Description="Kozmetik Ürünleri"}
            };
            if (!context.Categories.Any())
            {
                foreach (var category in categories)
                {
                    context.Categories.Add(category);
                    context.SaveChanges();
                }
            }
            //SubCategories
            List<SubCategory> subCategories = new List<SubCategory>()
            {
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Bilgisayar",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Teknoloji").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Televizyon",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Teknoloji").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Telefon",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Teknoloji").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Tshirt",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Giyim").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Ayakkabı",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Giyim").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Jean",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Giyim").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Roman",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kitap").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Edebiyat",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kitap").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Felsefe",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kitap").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Parfüm",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kozmetik").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Eyeliner",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kozmetik").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Fonfoten",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kozmetik").ID},
                new SubCategory{ID = Guid.NewGuid(),SubCategoryName="Ruj",CategoryId=categories.FirstOrDefault(x=>x.CategoryName == "Kozmetik").ID}
            };
            if (!context.SubCategories.Any())
            {
                foreach (var subCategory in subCategories)
                {
                    context.SubCategories.Add(subCategory);
                    context.SaveChanges();  
                }
            }
            //Suppliers
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier{ID = Guid.NewGuid(), CompanyName="Özkardeşler Tic", Address="İstanbul"},
                new Supplier{ID = Guid.NewGuid(), CompanyName="Demir Lojistik Tic", Address="İstanbul"},
                new Supplier{ID = Guid.NewGuid(), CompanyName="Kuzey yeli deposu Tic", Address="İstanbul"},
                new Supplier{ID = Guid.NewGuid(), CompanyName="Ikura ve Chang Kardeşler Tedarik Tic", Address="İstanbul"}
            };
            if (!context.Suppliers.Any())
            {
                foreach (var supplier in suppliers)
                {
                    context.Suppliers.Add(supplier);
                    context.SaveChanges();
                }
            }
            //Products
            List<Product> products = new List<Product>()
            {
                new Product{ID = Guid.NewGuid(), ProductName="MSI",SubCategoryId=subCategories.FirstOrDefault(x=>x.SubCategoryName =="Bilgisayar").ID,SupplierId=suppliers.FirstOrDefault(x=>x.CompanyName =="Özkardeşler Tic").ID,UnitInStock=50,UnitPrice=15000,ProductImagePath="/Content/product/msi_computer.png"},
                new Product{ID = Guid.NewGuid(), ProductName="Arçelik LCD",SubCategoryId=subCategories.FirstOrDefault(x=>x.SubCategoryName =="Televizyon").ID,SupplierId=suppliers.FirstOrDefault(x=>x.CompanyName =="Demir Lojistik Tic").ID,UnitInStock=150,UnitPrice=20000,ProductImagePath="/Content/product/arcelik_led.png"},
                new Product{ID = Guid.NewGuid(), ProductName="Iphone 13 Pro Max",SubCategoryId=subCategories.FirstOrDefault(x=>x.SubCategoryName =="Telefon").ID,SupplierId=suppliers.FirstOrDefault(x=>x.CompanyName =="Kuzey yeli deposu Tic").ID,UnitInStock=150,UnitPrice=30000,ProductImagePath="/Content/product/iphone_13.png"}
            };
            if (!context.Products.Any())
            {
                foreach (var product in products)
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            //AppUser
            List<AppUser> userList = new List<AppUser>()
            {
                new AppUser{ID=Guid.NewGuid(),UserName="admin",Password="1234",Email="admin@admin.com"}
            };
            if (!context.AppUsers.Any())
            {
                foreach (var user in userList)
                {
                    context.AppUsers.Add(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
