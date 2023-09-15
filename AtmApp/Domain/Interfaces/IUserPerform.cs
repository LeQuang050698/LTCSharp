using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmApp.Domain.Interfaces
{
    public interface IUserPerform
    {
        void CheckBalance();
        void HandleDeposite();
        void HandleWithdraw();
    }
}