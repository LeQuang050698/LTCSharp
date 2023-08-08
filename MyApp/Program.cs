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
                } else {
                    Console.WriteLine("Please Re-Enter!");
                }
            }while(number != 1 && number != 2);
        }

        static void SetRectangle() {
            Console.WriteLine("Length Rectangle: ");
            float lengthRec = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Width Rectangle: ");
            float widthRec = Convert.ToSingle(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(lengthRec, widthRec);
            myRectangle.CalculateRec();     
        }
        static void SetTriangle() {
            Console.WriteLine("The First Side Of The Triangle: ");
            float firstEdge = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("The Second Side Of The Triangle: ");
            float secondEdge = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("The Third Side Of The Triangle: ");
            float thirdEdge = Convert.ToSingle(Console.ReadLine());

            Triangle myTriangle = new Triangle(firstEdge, secondEdge, thirdEdge);
            myTriangle.CalculateTria();
        }
    }

}