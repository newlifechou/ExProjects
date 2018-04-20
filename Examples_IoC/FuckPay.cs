using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    /// <summary>
    /// 演示方法注入
    /// </summary>
    class FuckPay
    {
        private ICard card;

        [Inject]
        public void SetFucker(ICard card)
        {
            this.card = card;
        }

        public void Run()
        {
            if (card != null)
            {
                card.Diposite(2000);
                card.Withdraw(4500);
            }
        }

    }
}
