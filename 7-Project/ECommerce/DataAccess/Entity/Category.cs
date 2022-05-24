using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace DataAccess.Entity
{
    public class Category:EntityRepository
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //Lazy Load => Category.SubCategory çağırılmadığı sürece listelenmeyecek. Performance açısından verim sağlar. İlişkilendirme virtual tanımlanıp lazy load yapılır..
        public virtual List<SubCategory> SubCategories { get; set; }
    }
}
