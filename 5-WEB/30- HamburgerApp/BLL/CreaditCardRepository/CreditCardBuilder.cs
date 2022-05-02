using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public abstract class CreditCardBuilder
    {
        protected CreditCard card;

        public CreditCard Card
        {
            get { return card; }
        }

        public abstract void BankName();
        public abstract void CardType();
        public abstract decimal CardLimit();
    }
}
