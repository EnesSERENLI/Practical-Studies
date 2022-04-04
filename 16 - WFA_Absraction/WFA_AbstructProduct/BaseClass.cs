using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstructProduct
{
    public abstract class BaseClass
    {
        //Custom Properties
        public DateTime CreateDate { get; set; }
        public abstract bool IsActive { get; set; }
        //Methods
        //public abstract void Add(Product p);
        public abstract Category Add(Category c);
        public abstract Supplier Add(Supplier s);
        public abstract Product Add(Product p);
        public abstract void Delete(string name);
        public abstract void Update(string name1, string name2);
        //public abstract string List(List<Product> p);
        //public abstract string List(List<Category> c);
        //public abstract string List(List<Supplier> s);
    }
}
