using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class ATM
    {
        public bool isValidNumber() => Number > 0 && Number < 3;
        public bool isValidNumberMenu() => Number > 0 && Number < 5;
        public bool isValidNumberWithdraw() => Number > 0 && Number < 10;
        public int Number {get;set;}
        public bool isValidBalance() => Balance > 0;
        public bool isValidAmount() => Amount > 0 && Amount %10000 != 0;
        public bool isValidWithdraw() => Balance > Amount;
        public long Balance {get;set;}
        public long Amount {get;set;}
    }
}