using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    class UnionPay
    {
        private ICard card;
        public ICard Card
        {
            set
            {
                card = value;
            }
        }
        public UnionPay(ICard c)
        {
            this.card = c;
        }
        public void Run(double money)
        {
            card.Diposite(money);
            card.Withdraw(money);
        }
    }
}
