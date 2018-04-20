using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    /// <summary>
    /// 演示属性注入
    /// </summary>
    class XSPay
    {
        [Inject]
        public ICard Card { get; set; }

        public void Run()
        {
            if(Card!=null)
            {
                Card.Diposite(2000);
                Card.Withdraw(4500);
            }
        }
    }
}
