using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Map;
using DataAccess.Entity;

namespace DataAccess.Map
{
    public class CategoryMap:CoreMap<Category> //=> CoreMap (Core KAtmanından geliyor) CategoryMap instance alınında onunda constructor'ı tetiklenecek..
    {
        public CategoryMap() //Constructor içerisinde kuralları belirliyoruz. Onmodelcreating'te database oluşturulurken 1 kere instance alacaz. 
        {
            ToTable("dbo.Categories"); //tablo ismini değiştirebilirz dbo.isim olarak gelmiyor => Categories olacak tablo adı..
            Property(x => x.CategoryName).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsOptional().HasMaxLength(255);
        }
    }
}
