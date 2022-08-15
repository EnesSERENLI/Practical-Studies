using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class OrderDetailMap : BaseEntityMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("OrderDetails");
            Property(x => x.UnitPrice).IsRequired();
            Property(x => x.Quantity).IsRequired();
            Property(x => x.SubTotal).IsRequired();
        }
    }
}
