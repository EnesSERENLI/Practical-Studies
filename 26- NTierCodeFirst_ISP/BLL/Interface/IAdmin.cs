using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface IAdmin
    {
        /// <summary>
        /// Shows how many types of products are in a category.
        /// </summary>
        void ReportProductWithCategory();
        /// <summary>
        /// Lists the products between the two specified prices.
        /// </summary>
        /// <param name="price1"></param>
        /// <param name="price2"></param>
        void ReportProductWithPrice(int price1, int price2);

        /// <summary>
        /// Lists the products over the specified stock amount.
        /// </summary>
        /// <param name="stock"></param>
        void ReportProductWithStock(int stock);
    }
}
