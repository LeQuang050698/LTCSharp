using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmApp.UI;

namespace AtmApp.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            ATMApp atmApp = new ATMApp();
            atmApp.InitializeData();
            atmApp.ProcessMenuLogin();
        }
    }
}