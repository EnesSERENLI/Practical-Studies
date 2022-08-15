using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class OrderMap : BaseEntityMap<Order>
    {
        public OrderMap()
        {
            ToTable("Orders");
            Property(x => x.OrderDate).IsRequired();
        }
    }
}
