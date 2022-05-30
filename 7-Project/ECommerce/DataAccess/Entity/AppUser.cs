﻿using Core;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class AppUser:EntityRepository
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Guid ActivationCode { get; set; }
        public bool IsActive { get; set; }

        public virtual List<AppUserAndRole> AppUserAndRoles { get; set; }
    }
}
