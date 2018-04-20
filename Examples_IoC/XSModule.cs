using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace Examples_IoC
{
    class XSModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICard>().To<Card_ABC>();
            Bind<XSPay>().ToSelf();
        }
    }
}
