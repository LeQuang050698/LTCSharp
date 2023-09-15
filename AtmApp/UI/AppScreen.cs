using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmApp.App;
using AtmApp.Domain.Component;

namespace AtmApp.UI
{
    public class AppScreen
    {
        internal static void ScreenLogin()
        {
            Console.WriteLine("1.ATM App");
            Console.WriteLine("2.Exit");
        }

        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();
            tempUserAccount.UserId = Validator.Convert<long>("User ID");
            return tempUserAccount;
        }
        internal static void ScreenAppMenu(UserAccount currentAccount)
        {
            Console.WriteLine($"\n<----->Welcome {currentAccount.UserFullName}<----->\n");
            Console.WriteLine("1.Display balance");
            Console.WriteLine("2.Deposite");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Transfer");
            Console.WriteLine("5.Back to login screen");
        }
        internal static long OptionAmount()
        {
            Console.WriteLine("\n<-------------->Withdraw<-------------->\n");
            Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
            Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
            Console.WriteLine("7.10000000\t\t8.Other\t\t\t9.Back");
            int userChoose = Validator.Convert<int>("choose");
            switch(userChoose){
                case 1: return 100000;
                case 2: return 200000;
                case 3: return 500000;
                case 4: return 1000000;
                case 5: return 2000000;
                case 6: return 5000000;
                case 7: return 10000000;
                case 8: return 0;
                default: return -1;
            }
        }
        internal Transfer TransferForm()
        {
            var transfer = new Transfer();
            transfer.ReceiveUserId = Validator.Convert<long>("Recipient User ID");
            transfer.TransferAmount = Validator.Convert<long>("amount want to send");
            return transfer;
        }
    }
}