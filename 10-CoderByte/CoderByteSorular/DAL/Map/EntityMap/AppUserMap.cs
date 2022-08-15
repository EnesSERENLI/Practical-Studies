using DAL.Concrete;
using DAL.Map.BaseMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.EntityMap
{
    public class AppUserMap : BaseEntityMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            Property(x => x.LastName).IsRequired().HasMaxLength(50);
            Property(x => x.UserName).IsRequired().HasMaxLength(50);
            Property(x => x.Password).IsRequired().HasMaxLength(50);
            Property(x => x.ConfirmPassword).IsRequired().HasMaxLength(50);
            Property(x => x.Email).IsRequired();
        }
    }
}
