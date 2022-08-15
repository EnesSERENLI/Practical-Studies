using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class AppUserRoleMap : BaseEntityMap<AppUserRole>
    {
        public AppUserRoleMap()
        {
            Property(x => x.RoleName).IsRequired().HasMaxLength(50);
        }
    }
}
