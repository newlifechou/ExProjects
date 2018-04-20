using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    interface ICard
    {
        void Diposite(double money);
        void Withdraw(double money);
    }
}
