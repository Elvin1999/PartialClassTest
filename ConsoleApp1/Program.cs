using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    //PARTIAL CLASSES



    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount
            {
                BankName = "Kapital Bank",
                AccountNo = 12345
            };
            account.UpdateAccountNo(5555);
            account.ShowAccount();
            account.ShowBalanceCall();
            ////account.ShowBalance();
        }
    }
}
