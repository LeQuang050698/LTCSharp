using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinMaxNumber
{
    public class Program
    {
        static void Main(string[] args) {
            
            Console.Write("Enter Quantity Number Check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number <= 0) {
                Console.Write("Enter Quantity Number Check Again : ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            float[] numbersCheck = new float[number];

            for(var i = 0; i < number; ++i) {
                Console.Write($"Number Check {i}: ");
                numbersCheck[i] = Convert.ToSingle(Console.ReadLine()); 
            }

            float min = numbersCheck[0];
            float max = numbersCheck[0];

            for(var j = 1; j < number; ++j) {
                if(max < numbersCheck[j]) {
                    max = numbersCheck[j];
                } else if(max == numbersCheck[j]) {
                    Console.WriteLine("There is no maximum value");
                }

                if(min > numbersCheck[j]) {
                    min = numbersCheck[j];
                }else if(min == numbersCheck[j]) {
                    Console.WriteLine("There is no minimum value");
                }
            }

            Console.WriteLine($"The maximum value: {max}");
            Console.WriteLine($"The minimum value: {min}");
        }
    }
}