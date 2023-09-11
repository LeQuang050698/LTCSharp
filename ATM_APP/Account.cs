using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class Account
    {
        public long userId {get;set;}
        public long balance {get;set;}
        public long amount {get;set;}
        public Account() {}
        public Account(long userId,long balance, long amount){
            this.userId = userId;
            this.balance = balance;
            this.amount = amount;
        }
        public void InputUserId()
        {
            Console.Write("Enter User ID:");
            long user = Convert.ToInt64(Console.ReadLine());
            this.userId = user;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your User ID has:{this.balance} VND");
        }
        public void HandleWithdraw(){
            if(this.balance > this.amount) {
                this.balance -= this.amount;
                Console.WriteLine($"Your User ID has:{this.balance} VND");
            } else {
                Console.WriteLine("Your User ID is not enough to perform.");
            }
        }
        public void HandleDeposite()
        {
            Console.Write("Enter Deposite:");
            this.amount = Convert.ToInt64(Console.ReadLine());
            while(this.amount <= 0){
                Console.Write("Re-Enter Deposite:");
                this.amount = Convert.ToInt64(Console.ReadLine());
            }
            this.balance += this.amount;
            Console.WriteLine($"Your User ID is:{this.balance} VND");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Account: {this.userId}");
            Console.WriteLine($"Balance: {this.balance}");
        }
    }
}