using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public BaseEntity()
        {
            Status = Status.Active;
        }
        public Guid ID { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedComputerName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedIP { get; set; }
        public string UpdatedComputerName { get; set; }


    }
}
