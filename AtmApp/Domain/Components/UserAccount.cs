using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmApp.Domain.Component
{
    public class UserAccount
    {
        public int Id {get;set;}
        public string? UserFullName {get;set;}
        public long UserId {get;set;}
        public long UserBalance {get;set;}
        public int TotalLogin {get;set;}
    }
}