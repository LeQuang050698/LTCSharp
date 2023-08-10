using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifElse
{
    public class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("1:Geometry\t\t2:Algebra");
            Console.WriteLine();
            
            int number = 0;
            while(number != 1 && number !=2) {
                Console.Write("Please Choose: ");
                number = Convert.ToInt32(Console.ReadLine());
                int newNumber = 0;
                switch(number) {
                    case 1:
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine("1:Rectangle\t\t2:Circle\t\t3:Triangle");
                        Console.WriteLine();
                        while(newNumber != 1 & newNumber != 2 && newNumber != 3) {
                            Console.Write("Please Choose: ");
                            newNumber = Convert.ToInt32(Console.ReadLine());
                            switch(newNumber) {
                                case 1: setRectangle(); break;
                                case 2: setCircle(); break;
                                case 3: setTriangle(); break;
                                default: Console.WriteLine("Please Choose Again: "); break;
                            }
                        }
                        break;
                    case 2: 
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("1:ax + b = 0\t\t2:ax^2 + bx + c =0");
                        Console.WriteLine();
                        while(newNumber != 1 & newNumber != 2) {
                            Console.Write("Please Choose: ");
                            newNumber = Convert.ToInt32(Console.ReadLine());
                            switch(newNumber) {
                                case 1: break;
                                case 2: break;
                                default: Console.WriteLine("Please Choose Again: "); break;
                            }
                        }
                        break;
                    default: Console.WriteLine("Please Choose Again: "); break;
                }
            }
        }
        static void setRectangle() {
            var myRectangle = new Rectangle();

            Console.Write("Length Rectangle: ");
            myRectangle.Length = Convert.ToSingle(Console.ReadLine());
            while(!myRectangle.isValidLength()) {
                Console.Write("Length Rectangle Again: ");
                myRectangle.Length = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Width Rectangle: ");
            myRectangle.Width = Convert.ToSingle(Console.ReadLine());
            while(!myRectangle.isValidWidth()) {
                Console.Write("Width Rectangle Again: ");
                myRectangle.Width = Convert.ToSingle(Console.ReadLine());
            }
            if(myRectangle.Length == myRectangle.Width) {
                Console.WriteLine("This is a Square");
            }
            Console.WriteLine($"Perimeter Rectangle: {myRectangle.Perimeter}");
            Console.WriteLine($"Acreage Rectangle: {myRectangle.Acreage}");
        }

        static void setCircle() {
            var myCircle = new Circle();

            Console.Write("Radius Circle: ");
            myCircle.Radius = Convert.ToSingle(Console.ReadLine());
            while(!myCircle.isValidRadius()) {
                Console.Write("Radius Circle Again: ");
                myCircle.Radius = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine($"Perimeter Circle: {myCircle.Perimeter}");
            Console.WriteLine($"Acreage Circle: {myCircle.Acreage}");
        }

        static void setTriangle() {
            var myTriangle = new Triangle();
            
            Console.Write("First Edge: ");
            myTriangle.FirstEdge = Convert.ToSingle(Console.ReadLine());
            while(!myTriangle.isValidFirstEdge()) {
                Console.Write("First Edge Again: ");
                myTriangle.FirstEdge = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Second Edge: ");
            myTriangle.SecondEdge = Convert.ToSingle(Console.ReadLine());
            while(!myTriangle.isValidSecondEdge()) {
                Console.Write("Second Edge Again: ");
                myTriangle.SecondEdge = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Third Edge: ");
            myTriangle.ThirdEdge = Convert.ToSingle(Console.ReadLine());
            while(!myTriangle.isValidThirdEdge()) {
                Console.Write("Third Edge Again: ");
                myTriangle.ThirdEdge = Convert.ToSingle(Console.ReadLine());
            }

            if(!myTriangle.isValidTriangle()) {
                if(myTriangle.isValidRightTriangle()) {
                    Console.WriteLine("This is a Right Triangle");
                } else if(myTriangle.isValidIsoscelesTriangle()) {
                    Console.WriteLine("This is a Isosceles Triangle");
                } else if(myTriangle.isValidEquilateralTriangle()) {
                    Console.WriteLine("This is a Equilateral Triangle");
                }
                Console.WriteLine($"Perimeter Triangle: {myTriangle.Perimeter}");
                Console.WriteLine($"Acreage Triangle: {myTriangle.Acreage}");
            } else {
                Console.WriteLine("This is not a Triangle");
            }
        }

        static void set
    }
}