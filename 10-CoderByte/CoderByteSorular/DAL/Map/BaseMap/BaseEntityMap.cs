using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map.BaseMap
{
    public class BaseEntityMap<T>:EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseEntityMap()
        {
            Property(x => x.CreatedIP).IsOptional().HasMaxLength(255);
            Property(x => x.CreatedComputerName).IsOptional().HasMaxLength(255);
            Property(x => x.CreatedDate).IsOptional();

            Property(x => x.UpdatedComputerName).IsOptional().HasMaxLength(255);
            Property(x => x.UpdatedIP).IsOptional().HasMaxLength(255);
            Property(x => x.UpdatedDate).IsOptional();
        }
    }
}
