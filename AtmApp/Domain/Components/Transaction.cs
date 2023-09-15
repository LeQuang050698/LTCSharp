using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmApp.Domain.Enums;

namespace AtmApp.Domain.Component
{
    public class Transaction
    {
        public long TransactionId {get;set;}
        public long UserIdBank {get;set;}
        public TransactionType TransactionType {get;set;}
        public long TransactionAmount {get;set; }
    }
}