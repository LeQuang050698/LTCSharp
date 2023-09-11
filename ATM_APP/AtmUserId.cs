using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class AtmUserId
    {
        public long userId {get; set;}
        public long balance {get; set;}
        public long amount {get; set;}
        public AtmUserId() { }
        public AtmUserId(long userId ,long balance)
        {
            this.userId = userId;
            this.balance = balance;
        }
        public void showBalance() {
            Console.WriteLine($"Your Account has: {this.balance}");
        }
        public void handleWithdraw() {
            if(this.balance > this.amount){
                this.balance -= this.amount;
                Console.WriteLine($"Your account has:{this.balance} VND");
            }else{
                Console.WriteLine("Your account is not enough to perform. Please deposit");
            }
        }
        public void handleDeposite()
        {
            Console.Write("Enter Deposite:");
            this.amount = Convert.ToInt64(Console.ReadLine());
            while(this.amount <= 0)
            {
                Console.Write("Re-Enter Deposite:");
                this.amount = Convert.ToInt64(Console.ReadLine());
            }
            this.balance += this.amount;
            Console.WriteLine($"Your account has:{this.balance} VND");
        }

    }
}