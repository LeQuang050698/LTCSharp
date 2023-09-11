using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    class Program
    {
        public static List<Account>? ListUsersID { get; private set; }

        static void ShowMenuLogin()
        {
            Console.WriteLine("1.User ID");
            Console.WriteLine("2.Exit");
            int choice = 0;
            while(choice != 1 && choice != 2){
                Console.Write("Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case 1:
                        Account userId = new Account();
                        userId.InputUserId();
                        ShowMainMenu(userId);
                        ListUsersID.Add(userId);
                        int index = 1;
                        foreach(Account id in ListUsersID){
                            id.ShowInfo();
                            index++;
                        }
                    break;
                    case 2:Console.WriteLine("Thank You & See You Again");break;
                    default:break;
                }
            } 
        }
        static void ShowMainMenu(Account userId)
        {
            Console.WriteLine("<==========>MENU<==========>");
            Console.WriteLine("1.Display balance");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Deposite");
            Console.WriteLine("4.Back to login screen");
            int choice = 0;
            while(!(choice > 0 && choice < 5)){
                Console.Write("Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice){
                    case 1:
                        userId.ShowBalance();
                        ShowMainMenu(userId);
                    break;
                    case 2:
                        Console.WriteLine("<==========>Withdraw<==========>");
                        Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
                        Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
                        Console.WriteLine("7.1000000\t\t8.Enter Another\t\t9.Back");
                        int option = 0;
                        while(!(option > 0 && option < 10)){
                            Console.Write("Choice:");
                            option = Convert.ToInt32(Console.ReadLine());
                            switch(option){
                                case 1: userId.amount = 100000;break;
                                case 2: userId.amount = 200000;break;
                                case 3: userId.amount = 500000;break;
                                case 4: userId.amount = 1000000;break;
                                case 5: userId.amount = 2000000;break;
                                case 6: userId.amount = 5000000;break;
                                case 7: userId.amount = 10000000;break;
                                case 8:
                                    Console.Write("Enter Amount:");
                                    userId.amount = Convert.ToInt64(Console.ReadLine());
                                    while(!(userId.amount <= 0 && userId.amount == 0)){
                                        Console.Write("Enter Amount:");
                                        userId.amount = Convert.ToInt64(Console.ReadLine());
                                    }
                                break;
                                case 9:ShowMainMenu(userId);break;
                                default:break;
                            }
                        }
                    userId.HandleWithdraw();
                    ShowMainMenu(userId);
                    break;
                    case 3:
                        userId.HandleDeposite();
                        ShowMainMenu(userId);
                    break;
                    case 4:ShowMenuLogin(); break;
                }
            }
        }
        static void Main(string[] args)
        {
            ListUsersID = new List<Account>();
            ShowMenuLogin();
        }
    }
}