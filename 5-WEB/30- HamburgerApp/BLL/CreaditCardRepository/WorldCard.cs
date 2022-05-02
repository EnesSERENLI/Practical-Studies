using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public class WorldCard : CreditCardBuilder
    {
        public WorldCard()
        {
            card = new CreditCard();
        }
        public override void BankName()
        {
            Card.BankName = "Yapı Kredi";
        }

        public override void CardType()
        {
            Card.CardType = "WorldCard";
        }

        public override decimal CardLimit()
        {
            Card.CardLimit = 5000;
            return Card.CardLimit;  
        }

        public override string ToString()
        {
            return Card.CardType;
        }
    }
}
