using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class AppUserRole : BaseEntity
    {
        public string RoleName { get; set; }

        //Mapping
        public virtual List<AppUser> AppUsers { get; set; }
    }
}
