using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class CategoryMap : BaseEntityMap<Category>
    {
        public CategoryMap()
        {
            Property(x => x.CategoryName).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsOptional().HasMaxLength(255);
        }
    }
}
