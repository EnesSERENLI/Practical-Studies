using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface IProductService
    {
        string CreateProduct(Product product);
        string UpdateProduct(Product product);
        string DeleteProduct(int id);
    }
}
