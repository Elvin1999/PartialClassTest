using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class BankAccount
    {
        public void ShowAccount()
        {
            Console.WriteLine($"Bank Name : {BankName}");
            Console.WriteLine($"Bank account no : {AccountNo}");
        }

        partial void ShowBalance()
        {
            Console.WriteLine("You balance 1235 azn");
        }

        public void ShowBalanceCall() {
                ShowBalance();
        }

        public void ChangePasswordCall()
        {
            ChangePassword();
        }

        partial void ChangePassword()
        {
            Console.WriteLine("Your password changed successfully");
        }
    }
}
