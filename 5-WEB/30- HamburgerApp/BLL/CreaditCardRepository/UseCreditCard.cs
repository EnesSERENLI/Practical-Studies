using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CreaditCardRepository
{
    public class UseCreditCard
    {
        public void UseCard(CreditCardBuilder Card)
        {
            Card.BankName();
            Card.CardType();
            Card.CardLimit();
        }
    }
}
