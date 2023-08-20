using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string myString = Console.ReadLine();
            myString = myString.Replace(" ", string.Empty);
            myString = myString.Trim();
            while(myString.Length > 0)
            {
                Console.Write(myString[0] + ": ");
                int count = 0;

                for(int i = 0; i < myString.Length; ++i) {
                    if(myString[0] == myString[i]) {
                        count++;
                    }
                }
                Console.WriteLine(count);
                myString = myString.Replace(myString[0].ToString(), string.Empty);
            }

           
        }
    }
}