using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmApp.UI
{
    public static class Utility
    {
        private static long transId;
        public static long GetTransactionId()
        {
            return ++transId;
        }
        public static string GetUserInput(string prompt)
        {
            Console.Write($"Enter {prompt}: ");
            return Console.ReadLine();
        }
        public static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}