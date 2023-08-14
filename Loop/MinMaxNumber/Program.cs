using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinMaxNumber
{
    public class Program
    {
        static void Main(string[] args) {
            var program = new Program();
            
            Console.Write("Enter Quantity Number Check: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number <= 0) {
                Console.Write("Enter Quantity Number Check Again : ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            float[] numbers = new float[number];

            for(int i = 0; i < number; ++i){
                Console.Write($"Enter Number {i + 1}: ");
                numbers[i] = Convert.ToSingle(Console.ReadLine());
            }

            float max = numbers[0];
            float min = numbers[0];
            float maxSecond = numbers[0];
            float minSecond = numbers[0];

            for(int i = 1; i < number; ++i) {
                Array.Sort(numbers);
                max = numbers[i];
                maxSecond = numbers[i - 1];
                min = numbers[0];
                minSecond = numbers[1];
            }
            if(min == max) {
                Console.WriteLine("There is no maximum and minimum value");
            }else {
                if(max == maxSecond) {
                    Console.WriteLine("No 2nd largest value");
                } else {
                    Console.WriteLine($"The maximum value is: {max}");
                    Console.WriteLine($"The 2nd maximum value is: {maxSecond}");
                }
                if(min == minSecond) {
                    Console.WriteLine("No 2nd smallest value");
                }else {
                    Console.WriteLine($"The minimum value is: {min}");
                    Console.WriteLine($"The 2nd minimum value is: {minSecond}");
                }
            }
        }

    }
}