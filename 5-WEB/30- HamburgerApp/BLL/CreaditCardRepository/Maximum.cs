using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public class Maximum :CreditCardBuilder
    {
        public Maximum()
        {
            card = new CreditCard();
        }
        public override void BankName()
        {
            Card.BankName = "Türkiye İş Bankası";
        }

        public override void CardType()
        {
            Card.CardType = "Maximum";
        }

        public override decimal CardLimit()
        {
            Card.CardLimit = 100;
            return Card.CardLimit;
        }
        public override string ToString()
        {
            return Card.CardType;
        }
    }
}
