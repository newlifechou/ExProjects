using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace Examples_IoC
{
    class CardModule:NinjectModule
    {
        public override void Load()
        {

            Bind<ICard>().To<Card_ICBC>();
            Bind<TencentPay>().ToSelf();
        }
    }
}
