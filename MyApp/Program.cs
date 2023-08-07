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
            Console.WriteLine("Please Choose: \n 1: Triangle \n 2: Rectangle");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number == 1) {
                Console.Write("XY: ");
                float xy = Convert.ToSingle(Console.ReadLine());

                Console.Write("YZ: ");
                float yz = Convert.ToSingle(Console.ReadLine());

                Console.Write("ZX: ");
                float xz = Convert.ToSingle(Console.ReadLine());
                if(xy > 0 && yz > 0 && xz > 0) {
                    if(xy >= yz + xz || yz >= xz + xy || xz >= xy + yz) {
                        Console.WriteLine("This is a not Triangle");
                    } else {
                        Triangle xyz = new Triangle(xy, yz, xz);
                        xyz.PTriangle();
                        xyz.STriangle();
                    }
                } else {
                    Console.WriteLine("Please Re-Enter");
                }
            } else if(number == 2) {
                Console.Write("Length Rectangle: ");
                float lr = Convert.ToSingle(Console.ReadLine());

                Console.Write("Width Rectangle: ");
                float wr = Convert.ToSingle(Console.ReadLine());

                if(lr > 0 && wr > 0) {
                    Rectangle abcd = new Rectangle(lr, wr);
                    abcd.PRectangle();
                    abcd.SRectangle();
                } else {
                    Console.WriteLine("Please Re-Enter");

                }
            } else {
                Console.WriteLine("Please Re-Enter");
            }
        }
    }

}