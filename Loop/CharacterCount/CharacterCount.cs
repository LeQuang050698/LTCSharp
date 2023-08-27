using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            char[] charArr = str.ToCharArray();
            int Length = charArr.Length;
            
            for(int i = 0; i < Length; i++) {
                int count = charArr.Count(x => x == charArr[i]);
                int j;
                for(j = 0; j < Length; j++) {
                    if(charArr[i] == charArr[j]) {
                        break;
                    }
                }
                if(i == j) {
                    Console.WriteLine($"{charArr[i]}: {count}");
                }
                
            }
            string outputStr = Regex.Replace(str, @"(.)\1+", "$1");
            Console.Write(outputStr);
        }
    }
}