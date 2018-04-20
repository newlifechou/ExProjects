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
    }
}
