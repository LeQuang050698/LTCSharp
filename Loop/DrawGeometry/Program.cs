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
            var program = new Program();

            int number = 0;
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

            for(int i = 1; i <= myRectangle.Height; ++i){
                for(int j = 1; j <= myRectangle.Width; ++j)
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

            for(int i = myTriangle.Height; i >= 1; --i) {
                for(int j = 0; j <= myTriangle.Height; ++j) {
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

            for(int i = 1; i <= myTriangle.Height; ++i) {
                for(int j = 0; j < myTriangle.Height; ++j) {
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
            var myDiamondShape = new DiamondShape();

            Console.Write("Height Diamond Shape: ");
            myDiamondShape.Height = Convert.ToInt32(Console.ReadLine());
            while(!myDiamondShape.isValidHeight()) {
                Console.WriteLine("Please Re-Enter Height: ");
                myDiamondShape.Height = Convert.ToInt32(Console.ReadLine());
            }
            int i, j;

            for(i = 1; i <= myDiamondShape.Height; i+=2) {
                for(j = 1; j <= 2*myDiamondShape.Height; j+=2) {
                    if(Math.Abs(myDiamondShape.Height - j) <= i) {
                        Console.Write("*");
                    } else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }

            for(i = (myDiamondShape.Height - 2); i >= 1; i-=2) {
                for(j = 1; j <= 2*myDiamondShape.Height; j+=2 ) {
                    if(Math.Abs(myDiamondShape.Height - j) <= i ){
                        Console.Write("*");
                    }else {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}