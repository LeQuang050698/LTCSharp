using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class Choice
    {
        public bool isValidNumberLog() => Number > 0 && Number < 3;
        public bool isValidNumberMenu() => Number >0 && Number < 5;
        public bool isValidNumberWithdraw() => Number > 0 && Number < 10;
        public int Number {get;set;}
    }

    
}