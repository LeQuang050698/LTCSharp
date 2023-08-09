using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Choose:\n1:Rectangle\n2:Triangle");
            int number = 0;

            while(number != 1 && number != 2){
                Console.WriteLine("Your Choice:");
                number = Convert.ToInt32(Console.ReadLine());
                switch(number) {
                    case 1: SetRectangle(); break;
                    case 2: SetTriangle(); break;
                    default: Console.WriteLine("Please Re-Enter!"); break;
                }
            }
        }

        static void SetRectangle()
        {
            var myRectangle = new Rectangle();

            Console.WriteLine("Length Rectangle: ");
            myRectangle.Length = Convert.ToSingle(Console.ReadLine());
            while(!myRectangle.isValidLength()) {
                Console.WriteLine("Please Re-Enter Length:");
                myRectangle.Length = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Width Rectangle: ");
            myRectangle.Width = Convert.ToSingle(Console.ReadLine());
            while(!myRectangle.isValidWidth()) {
                Console.WriteLine("Please Re-Enter Width");
                myRectangle.Width = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine($"Perimeter Rectangle: {myRectangle.Perimeter()}");
            Console.WriteLine($"Acreage Rectangle: {myRectangle.Acreage()}");
        }

        static void SetTriangle() {
            var myTriangle = new Triangle();
            
            while(myTriangle.isValidTriangle()) {
                Console.WriteLine("First Edge: ");
                myTriangle.FirstEdge = Convert.ToSingle(Console.ReadLine());
                while(!myTriangle.isValidFirstEdge()) {
                    Console.WriteLine("Please Re-Enter First Edge:");
                    myTriangle.FirstEdge = Convert.ToSingle(Console.ReadLine());
                }

                Console.WriteLine("Second Edge: ");
                myTriangle.SecondEdge = Convert.ToSingle(Console.ReadLine());
                while(!myTriangle.isValidSecondEdge()) {
                    Console.WriteLine("Please Re-Enter Second Edge:");
                    myTriangle.SecondEdge = Convert.ToSingle(Console.ReadLine());
                }

                Console.WriteLine("Third Edge: ");
                myTriangle.ThirdEdge = Convert.ToSingle(Console.ReadLine());
                while(!myTriangle.isValidThirdEdge()) {
                    Console.WriteLine("Please Re-Enter Third Edge:");
                    myTriangle.ThirdEdge = Convert.ToSingle(Console.ReadLine());
                }

                if(myTriangle.isValidTriangle()) {
                    Console.WriteLine("This is not a Triangle\nPlease Try Again");
                }else {
                    Console.WriteLine($"Perimeter Triangle: {myTriangle.Perimeter()}");
                    Console.WriteLine($"Acreage Triangle: {myTriangle.Acreage()}");
                }
            }
        }
    }
}