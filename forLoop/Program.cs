using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------Drawing---------------------------------");
            Console.WriteLine("\n1:Rectangle\t 2:Triangle\t 3:Triangle Upside Down\t 4:Diamond Shape");
            int number = 0;
            var program = new Program();

            while(number != 1 && number != 2 && number != 3 && number != 4) 
            {
                Console.Write("Your Choice:");
                number = Convert.ToInt32(Console.ReadLine());
                switch(number) {
                    case 1: program.DrawRectangle(); break;
                    case 2: program.DrawTriangle(); break;
                    case 3: program.DrawTriangleUpsideDown(); break;
                    case 4: program.DrawDimondShape(); break;
                    default: Console.WriteLine("Please Choose Again!"); break;
                }
            }
        }

        public void DrawRectangle() {
            var myRectangle = new Rectangle();

            Console.Write("Width Rectangle: ");
            myRectangle.Width = Convert.ToInt32(Console.ReadLine());
            while(!myRectangle.isValidWidth()) {
                Console.WriteLine("Please Re-Enter Width:");
                myRectangle.Width = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Height Rectangle: ");
            myRectangle.Height = Convert.ToInt32(Console.ReadLine());
            while(!myRectangle.isValidHeight()) {
                Console.WriteLine("Please Re-Enter Height:");
                myRectangle.Height = Convert.ToInt32(Console.ReadLine());
            }

            for(var i = 1; i <= myRectangle.Height; ++i){
                for(var j = 1; j <= myRectangle.Width; ++j)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public void DrawTriangle()  
        {   
            var myTriangle = new Triangle();

            Console.Write("Height Triangle: ");
            myTriangle.Height = Convert.ToInt32(Console.ReadLine());
            while(!myTriangle.isValidHeight()) {
                Console.WriteLine("Please Re-Enter Height: ");
                myTriangle.Height = Convert.ToInt32(Console.ReadLine());
            }

            for(var i = myTriangle.Height; i >= 1; --i) {
                for(var j = 0; j <= myTriangle.Height; ++j) {
                    if(j <= myTriangle.Height - i) {
                        Console.Write("*");
                    }else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        public void DrawTriangleUpsideDown() {
            var myTriangle = new Triangle();

            Console.Write("Height Triangle: ");
            myTriangle.Height = Convert.ToInt32(Console.ReadLine());
            while(!myTriangle.isValidHeight()) {
                Console.WriteLine("Please Re-Enter Height: ");
                myTriangle.Height = Convert.ToInt32(Console.ReadLine());
            }

            for(var i = 1; i <= myTriangle.Height; ++i) {
                for(var j = 0; j < myTriangle.Height; ++j) {
                    if(j <= myTriangle.Height - i) {
                        Console.Write("*");
                    }else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        public void DrawDimondShape() {
            var myDimondShape = new DiamondShape();

            Console.Write("Height Diamond Shape: ");
            myDimondShape.Height = Convert.ToInt32(Console.ReadLine());
            while(!myDimondShape.isValidHeight()) {
                Console.WriteLine("Please Re-Enter Height: ");
                myDimondShape.Height = Convert.ToInt32(Console.ReadLine());
            }

            for(var i = 1; i <= myDimondShape.Height; ++i) {
                for(var j = 1; j < 2*myDimondShape.Height; ++j) {
                    if(Math.Abs(myDimondShape.Height - j) < i) {
                        Console.Write("*");
                    } else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}