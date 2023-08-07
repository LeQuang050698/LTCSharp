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
            Console.WriteLine("Vui Long Chon 1: Triangle or 2: Rectangle");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number == 1) {
                Console.Write("Canh a: ");
                float canhA = Convert.ToSingle(Console.ReadLine());
                Console.Write("Canh b: ");
                float canhB = Convert.ToSingle(Console.ReadLine());
                Console.Write("Canh c: ");
                float canhC = Convert.ToSingle(Console.ReadLine());

                Triangle xyz = new Triangle(canhA, canhB, canhC);
                xyz.ChuViTriangle();
                xyz.DienTichTriangle();
            }
            if(number == 2) {
                Console.Write("Chieu Dai: ");
                float cd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Chieu Rong: ");
                float cr = Convert.ToSingle(Console.ReadLine());

                Rectangle abcd = new Rectangle(cd, cr);
                abcd.ChuViRectangle();
                abcd.DienTichRectangle();
            }
        }
    }

}