using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ATM_ConsoleApp
{
    public class ATM_App
    {
        public static long balance { get; private set; }

        static void Main(string[] args)
        {
            // id: 77882664, 664444442
            string path = "users.csv";
            Dictionary<long, long> usersId = new Dictionary<long, long>();

            int choice = 0;
            long userId = 0;
            long balance = default;
            long amount = default;
            Console.WriteLine("<=====>Menu<=====>");
            Console.WriteLine("1.User Id");
            Console.WriteLine("0.Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice) {
                case 0: break;
                case 1: 
                    while(true) {
                        balance = 0;
                        Console.Write("Enter User Id:");
                        userId = Convert.ToInt64(Console.ReadLine());

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
                                currentMenu = Convert.ToInt32(Console.ReadLine());
                                switch(currentMenu) {
                                    case 1: Console.WriteLine($"Your account has:{balance} VNĐ");break;
                                    case 2:
                                        Console.WriteLine("<=====>Withdraw<=====>");
                                        Console.WriteLine("1.100000\t\t2.200000\t\t3.500000");
                                        Console.WriteLine("4.1000000\t\t5.2000000\t\t6.5000000");
                                        Console.WriteLine("7.1000000\t\t8.Enter Another:\t0.Back");
                                        previousMenu = currentMenu;
                                        currentMenu = Convert.ToInt32(Console.ReadLine());
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
                                                amount = Convert.ToInt64(Console.ReadLine());
                                                while(amount %10000 != 0) {
                                                    Console.Write("Please Re-Enter:");
                                                    amount = Convert.ToInt64(Console.ReadLine());
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
                                        currentMenu = Convert.ToInt32(Console.ReadLine());
                                    break;
                                    case 3:
                                        Console.Write("Enter deposit amount:");
                                        amount = Convert.ToInt64(Console.ReadLine());
                                        while(amount <= 0) {
                                            Console.Write("Please Re-Enter Deposit:");
                                            amount = Convert.ToInt64(Console.ReadLine());
                                        }
                                        balance += amount;
                                        Console.WriteLine($"Your account has:{balance} VNĐ");
                                        Console.WriteLine("0.Back");
                                        currentMenu = Convert.ToInt32(Console.ReadLine());
                                    break;
                                }
                            }
                        }
                        usersId.Add(userId,balance);
                        StringBuilder csv = new StringBuilder();
                        csv.AppendLine("userId,balance");
                        foreach(KeyValuePair<long, long> user in usersId) {
                            csv.AppendLine(string.Format("{0},{1}", user.Key, user.Value));
                        }
                        File.WriteAllText(path, csv.ToString());
                        Console.WriteLine("The file has been saved {0}", path);
                    }
                default: break;
            }
        }
    }
}