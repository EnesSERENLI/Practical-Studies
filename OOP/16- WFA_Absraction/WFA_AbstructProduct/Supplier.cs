using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_AbstructProduct
{
    public class Supplier:BaseClass
    {
        public Supplier(string companyName, string pNumber, string adress)
        {
            CompanyName = companyName;
            PhoneNumber = pNumber;
            Address = adress;
        }
        public Supplier()
        {

        }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public override bool IsActive { get; set; }

        public override Product Add(Product p)
        {
            return p;
        }

        public override Category Add(Category c)
        {
            return c;
        }

        public override Supplier Add(Supplier s)
        {
            FakeDatabase.Database.supplierList.Add(s);
            return s;
        }

        public override void Delete(string companyName)
        {
            foreach (Supplier s in FakeDatabase.Database.supplierList)
            {
                if (s.CompanyName == companyName)
                {
                    FakeDatabase.Database.supplierList.Remove(s);
                }
            }
        }

        public override string ToString()
        {
            return CompanyName;
        }

        public override void Update(string companyName, string updateCompanyName)
        {
            foreach (Supplier s in FakeDatabase.Database.supplierList)
            {
                if (s.CompanyName == companyName)
                {
                    s.CompanyName = updateCompanyName;
                }
            }
        }

        //public override string Add()
        //{

        //}

        //public override string Delete()
        //{

        //}

        //public override string List()
        //{

        //}

        //public override string Update()
        //{

        //}
    }
}
