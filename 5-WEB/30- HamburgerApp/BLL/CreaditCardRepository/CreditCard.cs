using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public class CreditCard
    {
        public int ID { get; set; }
        public string BankName { get; set; }
        public decimal CardLimit { get; set; }
        public string CardType { get; set; }
    }
}
