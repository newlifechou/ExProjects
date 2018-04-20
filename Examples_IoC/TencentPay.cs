using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    /// <summary>
    /// 演示构造函数注入
    /// </summary>
    class TencentPay
    {
        private readonly ICard card;
        [Inject]
        public TencentPay(ICard c)
        {
            this.card = c;
        }

        public void Run()
        {
            card.Diposite(2000);
            card.Withdraw(3000);
        }
    }
}
