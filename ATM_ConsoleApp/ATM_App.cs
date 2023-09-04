using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_ConsoleApp
{
    public class ATM_App
    {
        static void Main(string[] args)
        {
            string[] ids = new string[] {"77882664","664444442"};
            long balance = default;
            long amount = default;

            while(true)
            {
                Console.Write("Enter user id:");
                var userId = Console.ReadLine();
                int index = Array.IndexOf(ids, userId);
                while(index == -1) {
                    Console.Write("Please Re-enter user Id:");
                    userId = Console.ReadLine();
                    index = Array.IndexOf(ids, userId);
                }
                if(index != -1) {
                    int currentMenu = 0;
                    int previousMenu = default;
                    while(currentMenu == 0) {
                        if(currentMenu == 0) {
                            Console.WriteLine("<=====>Menu<=====>");
                            Console.WriteLine("1.Display balance");
                            Console.WriteLine("2.Withdraw");
                            Console.WriteLine("3.Deposite");
                            Console.WriteLine("4.Back to login screen");
                            previousMenu = currentMenu;
                            currentMenu = int.Parse(Console.ReadLine());
                            switch(currentMenu){
                                case 1:
                                    Console.WriteLine($"Your account has:{balance} VNĐ");
                                    Console.WriteLine("0.Back");
                                    currentMenu = int.Parse(Console.ReadLine());
                                break;
                                case 2:
                                    Console.WriteLine("-------------------------------------");
                                    Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
                                    Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
                                    Console.WriteLine("7.1000000\t\t8.Enter Another:\t0.Back");
                                    previousMenu = currentMenu;
                                    currentMenu = int.Parse(Console.ReadLine());
                                    switch(currentMenu) {
                                        case 0: currentMenu = 0; break;
                                        case 1: amount = 100000; break;
                                        case 2: amount = 200000; break;
                                        case 3: amount = 500000; break;
                                        case 4: amount = 1000000; break;
                                        case 5: amount = 2000000; break;
                                        case 6: amount = 5000000; break;
                                        case 7: amount = 10000000; break;
                                        case 8:
                                            Console.Write("Enter Another Money:");
                                            amount = int.Parse(Console.ReadLine());
                                            while(amount %10000 != 0) {
                                                Console.Write("Please Re-Enter:");
                                                amount = int.Parse(Console.ReadLine());
                                            }
                                        break;
                                        default: break;
                                    }
                                    if(balance > amount) {
                                        balance -= amount;
                                        Console.WriteLine($"Your account has:{balance} VNĐ");
                                    } else {
                                        Console.WriteLine("Your account is not enough to perform. Please deposit");
                                    }
                                    Console.WriteLine("0.Back");
                                    currentMenu = int.Parse(Console.ReadLine());
                                break;
                                case 3:
                                    Console.Write("Enter deposit amount:");
                                    amount = int.Parse(Console.ReadLine());
                                    while(amount <= 0) {
                                        Console.Write("Please Re-Enter Deposit:");
                                        amount = int.Parse(Console.ReadLine());
                                    }
                                    balance += amount;
                                    Console.WriteLine($"Your account has:{balance} VNĐ");
                                    Console.WriteLine("0.Back");
                                    currentMenu = int.Parse(Console.ReadLine());
                                break;
                                case 4: 
                                    Console.WriteLine("Thank you & See You Again");
                                    Console.WriteLine("<========================>");
                                break;
                                default: break;
                            }
                        }
                    }
                }
            }
        }
    }
}