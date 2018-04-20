using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_IoC
{
    class Card_ABC : ICard
    {
        private string bank_name = "ABC";
        public void Diposite(double money)
        {
            Console.WriteLine($"deposite {money} in {bank_name}");
        }

        public void Withdraw(double money)
        {
            Console.WriteLine($"deposite {money} in {bank_name}");
        }
    }
}
