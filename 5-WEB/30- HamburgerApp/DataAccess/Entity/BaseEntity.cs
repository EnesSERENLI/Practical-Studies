using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public abstract class BaseEntity
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }
        public abstract bool IsActive { get; set; }
    }
}
