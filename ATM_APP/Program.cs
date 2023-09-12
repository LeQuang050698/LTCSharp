using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            long amount = default;
            var ListUsersId = new Dictionary<long, long>(){{12345678,100000000}};
            AtmUserId user = new AtmUserId();
            ShowMenuLogin(user,ListUsersId,amount);
        }

        static void ShowMenuLogin(AtmUserId currentUser, Dictionary<long,long> ListUsersId,long amount)
        {
            Console.WriteLine("1.User ID");
            Console.WriteLine("2.Exit");
            int userChoose = 0;
            while(userChoose != 1 && userChoose != 2)
            {
                Console.Write("Choose:");
                userChoose = Convert.ToInt32(Console.ReadLine());
                switch(userChoose){
                    case 1:
                        Console.Write("Enter User ID:");
                        currentUser.userId = Convert.ToInt64(Console.ReadLine());
                        ListUsersId.Add(currentUser.userId,currentUser.balance);

                        foreach(KeyValuePair<long,long> ListUserId in ListUsersId) {
                            Console.WriteLine($"{ListUserId.Key}: {ListUserId.Value}");
                        }
                    break;
                    case 2: Console.WriteLine("Thank You & See You Again");break;
                    default:break;
                }
            }
        }
        static void ShowMainMenu(AtmUserId currentUser, Dictionary<long,long> ListUsersId,long amount)
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
                    case 1:
                        currentUser.showBalance();
                        ShowMainMenu(currentUser,ListUsersId,amount);    
                    break;
                    case 2:
                        Withdraw(currentUser);
                        ShowMainMenu(currentUser,ListUsersId,amount);    
                    break;
                    case 3:
                        currentUser.handleDeposite();
                        ShowMainMenu(currentUser,ListUsersId,amount);    
                    break;
                    case 4:
                        ShowMenuLogin(currentUser,ListUsersId,amount);break;
                    default:break;
                }
            }
        }
        static void Withdraw(AtmUserId currentUser)
        {
            Console.WriteLine("<==========>Withdraw<==========>");
            Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
            Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
            Console.WriteLine("7.10000000\t\t8.Enter Another\t\t9.Back");
            int userChoose = 0;
            while(!(userChoose > 0 && userChoose < 10)){
                Console.Write("Choose:");
                userChoose = Convert.ToInt32(Console.ReadLine());
                switch(userChoose){
                    case 1: currentUser.amount = 100000; break;
                    case 2: currentUser.amount = 200000; break;
                    case 3: currentUser.amount = 500000; break;
                    case 4: currentUser.amount = 1000000; break;
                    case 5: currentUser.amount = 2000000; break;
                    case 6: currentUser.amount = 5000000; break;
                    case 7: currentUser.amount = 10000000; break;
                    case 8:
                        Console.Write("Enter Another Money:");
                        currentUser.amount = Convert.ToInt64(Console.ReadLine());
                        while(currentUser.amount %10000 != 0) {
                            Console.Write("Please Re-Enter:");
                            currentUser.amount = Convert.ToInt64(Console.ReadLine());
                        }
                    break;
                } 
            }
            currentUser.handleWithdraw();
        }
    }
}