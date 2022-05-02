using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_KitapKutusu
{
    public class Urun
    {
        public int urunId { get ; set ; }
        public string urunName { get ; set ; }
        public Category category { get ; set ; }
        public decimal Fiyat { get ; set ; }
    }

    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }

}
