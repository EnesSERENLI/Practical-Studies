using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Extra : BaseEntity
    {
        private Extra()
        {
            IsActive = true;
        }
        public override int ID { get ; set ; }
        public override string Name { get ; set ; }
        public override decimal Price { get ; set ; }
        public override bool IsActive { get ; set ; }

        //Mapping

        //Bir extranın birden çok siparişi olabilir

        public List<Order_Detail> Order_Details { get; set; }

        //Instance(Singleton)
        private static Extra _extra;

        public static Extra ExtraInstance
        {
            get
            {
                if (_extra == null)
                {
                    _extra = new Extra();
                } 
                return _extra;
            } 
        }

       
    }
}
