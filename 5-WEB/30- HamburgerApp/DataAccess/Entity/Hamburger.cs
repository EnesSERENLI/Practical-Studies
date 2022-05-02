using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Hamburger : BaseEntity
    {
        private Hamburger()
        {
            IsActive = true;
        }
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override bool IsActive { get; set; }
        //Mapping

        //Bir hamburgerin bir den çok siparişi olabilir

        public List<Order> Orders { get; set; }

        //Instance (singleton)

        private static Hamburger _hamburger;

        public static Hamburger HamburgerInstance
        {
            get
            {
                if (_hamburger == null)
                {
                    _hamburger = new Hamburger();
                }
                return _hamburger;
            }
        }

        //public override string ToString()
        //{
        //    return $"{Name}";
        //}
    }
}
