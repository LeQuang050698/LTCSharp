using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmApp.Domain.Component
{
    public class Transfer
    {
        public long TransferAmount {get;set;}
        public long ReceiveUserId {get;set;}
    }
}