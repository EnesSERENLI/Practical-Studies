using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class ProductMap:BaseEntityMap<Product>
    {
        public ProductMap()
        {
            ToTable("dbo.Products");
            Property(x=>x.ProductName).IsRequired().HasMaxLength(255);
            Property(x => x.UnitPrice).IsRequired();
            Property(x=>x.Description).IsOptional().HasMaxLength(255);
            Property(x => x.UnitsInStock).IsRequired();
        }
    }
}
