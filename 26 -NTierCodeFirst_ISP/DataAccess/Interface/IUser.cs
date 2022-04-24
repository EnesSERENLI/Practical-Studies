using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IUser
    {
        int ID { get; set; }
        string UserName { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
