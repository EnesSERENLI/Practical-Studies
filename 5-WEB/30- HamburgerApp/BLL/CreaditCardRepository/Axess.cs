using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public class Axess : CreditCardBuilder
    {
        public Axess()
        {
            card = new CreditCard();
        }
        public override void BankName()
        {
            Card.BankName = "AkBank";
        }

        public override void CardType()
        {
            Card.CardType = "Axess";
        }

        public override decimal CardLimit()
        {
            Card.CardLimit = 3000;
            return Card.CardLimit;
        }
        public override string ToString()
        {
            return Card.CardType;
        }
    }
}
