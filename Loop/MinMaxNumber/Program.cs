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

            for(int i = 1; i < number; ++i) {
                if(max < numbers[i]){
                    max = numbers[i];
                }
                if(min > numbers[i]) {
                    min = numbers[i];
                }
            }
            if(min == max) {
                Console.WriteLine("There is no maximum and minimum value");
            }else {
                Console.WriteLine($"The maximum value is: {max}");
                Console.WriteLine($"The minimum value is: {min}");
            }

            float maxSecond = min;
            float minSecond = max;
            for(int i = 1; i < number; ++i) {
                if(maxSecond < numbers[i] && numbers[i] != max) {
                    maxSecond = numbers[i];
                }
                if(minSecond > numbers[i] && numbers[i] != min) {
                    minSecond = numbers[i];
                }
            }
            if(maxSecond == max) {
                Console.WriteLine("No 2nd largest value");
            }else {
                Console.WriteLine($"The second largest value is: {maxSecond}");
            }
            if(minSecond == min) {
                Console.WriteLine("No 2nd smallest value");
            }else {
                Console.WriteLine($"The second largest value is: {minSecond}");
            }
        }

    }
}