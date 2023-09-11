using System;
using System.Collections.Generic;  
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    class AtmApp
    {
        public long userId {get;set;}
        public long balance {get;set;}
        public AtmApp() { }
        public AtmApp(long userId,long balance)
        {
            this.userId = userId;
            this.balance = balance;
        }
        public static void Main(string[] args)
        {
            List<AtmApp> ListUsersID = new List<AtmApp>();
            ListUsersID.Add(new AtmApp(77882664, 0));
            ListUsersID.Add(new AtmApp(664444442, 0));
            void ShowMenuLogin(AtmApp currentUser)
            {
                
                Console.WriteLine("1.User ID");
                Console.WriteLine("2.Exit");
                int userChoose = 0;
                while(userChoose != 1 && userChoose != 2){
                    Console.Write("Choose:");
                    userChoose = Convert.ToInt32(Console.ReadLine());
                    switch(userChoose){
                        case 1:
                            Console.Write("Enter User ID:");
                            while(true){
                                try {
                                    long id = Convert.ToInt64(Console.ReadLine());
                                    currentUser = listUsersID.FirstOrDefault(a => a.userId == id);
                                    if(currentUser != null) { break; }
                                    else{
                                        Console.WriteLine("Please Try Again");
                                    }
                                } catch {Console.WriteLine("Please Try Again");}
                            }
                            ShowMainMenu(currentUser);
                        break;    
                        case 2: Console.WriteLine("Thank You & See You Again");break;
                        default: break;
                    }
                }
            }

            void ShowMainMenu(AtmApp currentUser)
            {
                Console.WriteLine("<==========>MENU<==========>");
                Console.WriteLine("1.Display balance");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposite");
                Console.WriteLine("4.Back to login screen");
                int userChoose = 0;
                while(!(userChoose > 0 && userChoose < 5)){
                    Console.Write("Choose:");
                    userChoose = Convert.ToInt32(Console.ReadLine());
                    switch(userChoose){
                        case 1: showBalance(currentUser);break;
                        case 2: handleWithdraw(currentUser);break;
                        case 3: handleDeposite(currentUser);break;
                        case 4: ShowMenuLogin(currentUser); break;
                        default: break;
                    }
                }
            }
            void showBalance(AtmApp currentUser)
            {
                Console.WriteLine($"Your account has:{currentUser.balance} VND");
            }
            void handleWithdraw(AtmApp currentUser)
            {
                long amount = 0;
                Console.WriteLine("<==========>Withdraw<==========>");
                Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
                Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
                Console.WriteLine("7.1000000\t\t8.Enter Another\t\t9.Back");
                int userChoose = 0;
                while(!(userChoose > 0 && userChoose < 10)){
                    Console.Write("Choose:");
                    userChoose = Convert.ToInt32(Console.ReadLine());
                    switch(userChoose){
                        case 1: amount = 100000; break;
                        case 2: amount = 200000; break;
                        case 3: amount = 500000; break;
                        case 4: amount = 1000000; break;
                        case 5: amount = 2000000; break;
                        case 6: amount = 5000000; break;
                        case 7: amount = 10000000; break;
                        case 8:
                            Console.Write("Enter Another Money:");
                            amount = Convert.ToInt64(Console.ReadLine());
                            while(amount %10000 != 0) {
                                Console.Write("Please Re-Enter:");
                                amount = Convert.ToInt64(Console.ReadLine());
                            }
                        break;
                        case 9: ShowMainMenu(currentUser); break;
                        default: break;
                    }
                }
                if(currentUser.balance > amount) {
                    currentUser.balance -= amount;
                    Console.WriteLine($"Your account has:{currentUser.balance} VND");
                } else {
                    Console.WriteLine("Your account is not enough to perform. Please deposit");
                }
            }
            void handleDeposite(AtmApp currentUser)
            {
                Console.Write("Enter Deposite:");
                long amount = Convert.ToInt64(Console.ReadLine());
                while(amount <= 0)
                {
                    Console.Write("Re-Enter Deposite:");
                    amount = Convert.ToInt64(Console.ReadLine());
                }
                currentUser.balance += amount;
                Console.WriteLine($"Your account has:{currentUser.balance} VND");
            }
        }
    }
}