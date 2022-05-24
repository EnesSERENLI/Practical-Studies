using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tools
{
    public class DbContextSingleton
    {
        private DbContextSingleton()
        {

        }

        private static EcommerceContext _context;
        public static EcommerceContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new EcommerceContext();
                }
                return _context;
            }
        }
    }
}
