using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
namespace ATM_APP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            long account = default;
            long balance = default;
            var usersID = new Dictionary<long, long>();
            program.ScreenLogin(account,balance,usersID);
        }
        public void ScreenLogin(long account,long balance,Dictionary<long,long> usersID)
        {
            var option = new Choice();
            Console.WriteLine("1.User ID");
            Console.WriteLine("2.Exit");
            while(!option.isValidNumberLog()){
                Console.Write("Enter Choice:");
                option.Number = Convert.ToInt32(Console.ReadLine());
                switch(option.Number){
                    case 1:
                        AddUserId(account);
                        ScreenMenu(balance);
                        usersID.Add(account,balance);
                        foreach(KeyValuePair<long,long>userID in usersID){
                            Console.WriteLine($"{userID.Key}:{userID.Value}");
                        }
                    break;
                    case 2:Console.WriteLine("Thank You & See You Again");break;
                    default:break;
                }
            }
        }
        public void AddUserId(long account)
        {
            Console.Write("Enter User Id:");
            account = Convert.ToInt64(Console.ReadLine());
        }
        public void ScreenMenu(long balance)
        {
            var option = new Choice();
            Console.WriteLine("<==========>MENU<==========>");
            Console.WriteLine("1.Display balance");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Deposite");
            Console.WriteLine("4.Back to login screen");
            while(!option.isValidNumberMenu()){
                Console.Write("Enter Choice:");
                option.Number = Convert.ToInt32(Console.ReadLine());
                switch(option.Number){
                    case 1:
                        Console.WriteLine($"Your User ID has:{balance} VND");
                        ScreenMenu(balance);
                    break;
                    case 2:Withdraw(balance);break;
                    case 3:Deposite(balance);break;
                    case 4:break;
                }
            }
        }
        public long Withdraw(long balance)
        {
            long amount = default;
            var option = new Choice();
            Console.WriteLine("<==========>Withdraw<==========>");
            Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
            Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
            Console.WriteLine("7.1000000\t\t8.Enter Another\t\t9.Back");
            while(!option.isValidNumberWithdraw()){
                Console.Write("Enter Choice:");
                option.Number = Convert.ToInt32(Console.ReadLine());
                switch(option.Number){
                    case 1:amount = 100000; break;
                    case 2:amount = 200000; break;
                    case 3:amount = 500000; break;
                    case 4:amount = 1000000; break;
                    case 5:amount = 2000000; break;
                    case 6:amount = 5000000; break;
                    case 7:amount = 10000000; break;
                    case 8:
                        Console.Write("Enter Amount:");
                        amount = Convert.ToInt64(Console.ReadLine());
                        while(!(amount <= 0 && amount == 0)){
                            Console.Write("Enter Amount:");
                            amount = Convert.ToInt64(Console.ReadLine());
                        }
                    break;
                    case 9:ScreenMenu(balance);break;
                }
                if(balance > amount) {
                    balance -= amount;
                    Console.WriteLine($"Your User ID has:{balance} VND");
                } else {
                    Console.WriteLine("Your User ID is not enough to perform.");
                }
                ScreenMenu(balance);
            }
            return balance;
        }
        public long Deposite(long balance)
        {
            Console.Write("Enter Deposite:");
            long amount = Convert.ToInt64(Console.ReadLine());
            while(amount <= 0){
                Console.Write("Re-Enter Deposite:");
                amount = Convert.ToInt64(Console.ReadLine());
            }
            balance += amount;
            Console.WriteLine($"Your User ID is:{balance} VND");
            ScreenMenu(balance);
            return balance;
        }
    }
}