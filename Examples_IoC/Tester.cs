using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    static class Tester
    {
        public static void Test_UnionPay()
        {
            Card_ABC abc = new Card_ABC();
            Card_ICBC icbc = new Card_ICBC();

            UnionPay unionPay = new UnionPay(abc);
            unionPay.Run(2000);
            unionPay.Card = icbc;
            unionPay.Run(3000);
        }

        public static void Test_Alipay()
        {
            new Alipay().Run();
        }

        public static void Test_TencentPay()
        {
            IKernel kernel = new StandardKernel(new CardModule());

            TencentPay pay = new TencentPay(kernel.Get<ICard>());

            TencentPay pay2 = kernel.Get<TencentPay>();
            pay.Run();
            pay2.Run();
        }

        public static void Test_XSPay()
        {
            IKernel kernel = new StandardKernel(new XSModule());
            XSPay xs = kernel.Get<XSPay>();
            xs.Run();

            XSPay xs2 = new XSPay() { Card = kernel.Get<ICard>() };
            xs2.Run();
        }

        public static void Test_FuckerPay()
        {
            IKernel kernel = new StandardKernel(new FuckModule());

            FuckPay pay = kernel.Get<FuckPay>();
            pay.Run();
            FuckPay pay2 = new FuckPay();
            pay2.SetFucker(kernel.Get<ICard>());
            pay2.Run();
        }
    }
}
