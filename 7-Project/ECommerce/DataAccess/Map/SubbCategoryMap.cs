using Core.Map;
using DataAccess.Entity;

namespace DataAccess.Map
{
    public class SubbCategoryMap:CoreMap<SubCategory>
    {
        public SubbCategoryMap()
        {
            ToTable("dbo.SubCategories");
            Property(x => x.SubCategoryName).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsOptional().HasMaxLength(255);
        }
    }
}
