using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmApp.Domain.Enums;

namespace AtmApp.Domain.Interfaces
{
    public interface ITransaction
    {
        void InsertTransaction(long _UserIdBank, TransactionType _transType, long _transAmount);
    }
}