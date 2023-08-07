using System.Dynamic;
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
            Console.WriteLine("1: Rectangle\n2: Triangle");
            int number;
            do {
                Console.WriteLine("Your Choice:");
                number = Convert.ToInt32(Console.ReadLine());
                if(number == 1) {
                    SetRectangle();
                } else if(number == 2) {
                    SetTriangle(); 
                }
            }while(number != 1 && number != 2);
        }

        static void SetRectangle() {
            float lengthRec, widthRec;
            do {
                Console.WriteLine("Length Rectangle: ");
                lengthRec = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Width Rectangle: ");
                widthRec = Convert.ToSingle(Console.ReadLine());

                if(lengthRec > 0 && widthRec > 0) {
                    Rectangle abcd = new Rectangle(lengthRec, widthRec);
                    abcd.PRectangle();
                    abcd.SRectangle();
                }else {
                    Console.WriteLine("Please Re-Enter!");
                }
            }while(lengthRec <= 0 || widthRec <= 0);
        }

        static void SetTriangle() {
            float firstEdge, secondEdge, thirdEdge;
            do {
                Console.WriteLine("The First Side Of The Triangle: ");
                firstEdge = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("The Second Side Of The Triangle: ");
                secondEdge = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("The Third Side Of The Triangle: ");
                thirdEdge = Convert.ToSingle(Console.ReadLine());

                if(firstEdge > 0 && secondEdge > 0 && thirdEdge > 0) {
                    if(firstEdge >= secondEdge + thirdEdge || secondEdge >= firstEdge + thirdEdge || thirdEdge >= firstEdge + secondEdge) {
                        Console.WriteLine("This is not a triangle");
                    } else {
                        Triangle xyz = new Triangle(firstEdge, secondEdge, thirdEdge);
                        xyz.PTriangle();
                        xyz.STriangle();
                    }
                }else {
                    Console.WriteLine("Please Re-Enter!");
                }
            }while (firstEdge <= 0 || secondEdge <= 0 || thirdEdge <= 0);
        }
        
    }

}