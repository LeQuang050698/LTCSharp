using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.ScreenLogin();
        }
        public void ScreenLogin()
        {
            var option = new ATM();
            Console.WriteLine("1.User ID");
            Console.WriteLine("2.Exit");
            while(!option.isValidNumber()){
                Console.Write("Enter choice:");
                option.Number = Convert.ToInt32(Console.ReadLine());
                switch(option.Number){
                    case 1:
                        UserIdInput();
                        while(true){
                            ScreenMenu();
                        }
                    // break;
                    case 2:Console.WriteLine("\nThank You & See You Again"); break;
                    default:Console.WriteLine("Re-Enter Number");break;
                }
            }
        }
        public void UserIdInput()
        {
            Console.Write("Enter User ID:");
            long userId = Convert.ToInt64(Console.ReadLine());
        }
        public void BackScreen()
        {
            Console.WriteLine("\nPress Enter To Return\n");
            Console.ReadKey();
            ScreenMenu();
        }
        public void ScreenMenu()
        {
            var option = new ATM();
            Console.WriteLine("<==========>MENU<==========>");
            Console.WriteLine("1.Display balance");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Deposite");
            Console.WriteLine("4.Back to login screen");
            while(!option.isValidNumberMenu()){
                Console.Write("Enter choice:");
                option.Number = Convert.ToInt32(Console.ReadLine());
                switch(option.Number){
                    case 1:ScreenBalance(); break;
                    case 2:Withdraw(); break;
                    case 3:Deposite(); break;
                    case 4:ScreenLogin(); break;
                    default: break;
                }
            }
        }
        public void ScreenBalance()
        {
            var userBalance = new ATM();
            if(!userBalance.isValidBalance()){
                userBalance.Balance = 0;
                Console.WriteLine($"Your account is {userBalance.Balance} VND");
                Console.WriteLine("Please deposit money");
            } else{
                Console.WriteLine($"Your account has:{userBalance.Balance} VND");
            }
            BackScreen();
        }
        public void Withdraw()
        {
            var makeWithdraw = new ATM();
            Console.WriteLine("<==========>Withdraw<==========>");
            Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
            Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
            Console.WriteLine("7.1000000\t\t8.Enter Another\t9.Back");
            while(!makeWithdraw.isValidNumberWithdraw()){
                Console.Write("Enter choice:");
                makeWithdraw.Number = Convert.ToInt32(Console.ReadLine());
                switch(makeWithdraw.Number){
                    case 1:makeWithdraw.Amount = 100000; break;
                    case 2:makeWithdraw.Amount = 200000; break;
                    case 3:makeWithdraw.Amount = 500000; break;
                    case 4:makeWithdraw.Amount = 1000000; break;
                    case 5:makeWithdraw.Amount = 2000000; break;
                    case 6:makeWithdraw.Amount = 5000000; break;
                    case 7:makeWithdraw.Amount = 10000000; break;
                    case 8:
                        Console.Write("Enter Amount Withdraw:");
                        makeWithdraw.Amount = Convert.ToInt64(Console.ReadLine());
                        while(!makeWithdraw.isValidAmount()){
                            Console.Write("Re-Enter Amount:");
                            makeWithdraw.Amount = Convert.ToInt64(Console.ReadLine());
                        }
                    break;
                }
            }
            if(makeWithdraw.isValidWithdraw()) {
                makeWithdraw.Balance -= makeWithdraw.Amount;
                Console.WriteLine($"Your User ID Balance: {makeWithdraw.Balance} VND");
            }else{
                Console.WriteLine("Your User ID is not enough to perform.");
            }   
            BackScreen();
        }
        public void Deposite()
        {
            var makeDeposite = new ATM();
            Console.WriteLine("<==========>Deposite<==========>");
            Console.WriteLine("1.Deposit money into your user ID");
            Console.WriteLine("2.Deposit money into other user ID");
            while(!makeDeposite.isValidNumber()){
                Console.Write("Enter choice:");
                makeDeposite.Number = Convert.ToInt32(Console.ReadLine());
                switch(makeDeposite.Number){
                    case 1:
                        Console.Write("Enter Amount Deposite:");
                        makeDeposite.Amount = Convert.ToInt64(Console.ReadLine());
                        while(makeDeposite.Amount <= 0){
                            Console.Write("Re-Enter Amount:");
                            makeDeposite.Amount = Convert.ToInt64(Console.ReadLine());
                        }
                        makeDeposite.Balance += makeDeposite.Amount;
                        Console.WriteLine($"Your User ID has: {makeDeposite.Balance} VND");
                        BackScreen();
                    break;
                }
            }
        }
    }
}