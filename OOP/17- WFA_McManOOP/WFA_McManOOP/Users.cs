using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_McManOOP
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

    }
    public enum Roles
    {
        Admin,Employee
    }
}
