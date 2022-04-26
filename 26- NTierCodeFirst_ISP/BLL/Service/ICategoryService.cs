using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface ICategoryService
    {
        string CreateCategory(Category category);
        string UpdateCategory(Category category);
        string DeleteCategory(int id);
    }
}
