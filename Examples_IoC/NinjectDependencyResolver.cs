using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
namespace Examples_IoC
{
    class NinjectDependencyResolver
    {
        private static NinjectDependencyResolver _instance;
        public static NinjectDependencyResolver Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NinjectDependencyResolver();
                }
                return _instance;
            }
        }

        private IKernel kernel;
        private NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            kernel.Bind<ICard>().To<Card_ABC>();
        }

        public T Resolve<T>()where T:class
        {
            return kernel.Get<T>();
        }



    }
}
