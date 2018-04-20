using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
namespace Examples_IoC
{
    class Alipay
    {
        private ICard card;
        public Alipay()
        {
            this.card = NinjectDependencyResolver.Instance.Resolve<ICard>(); ;
        }
        public void Run()
        {
            card.Diposite(2000);
            card.Withdraw(2000);
        }

    }
}
