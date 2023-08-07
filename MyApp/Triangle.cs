using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Triangle
    {
        float P;
        double C,S;
        public Triangle(float edge01, float edge02, float edge03){
            Edge01 = edge01;
            Edge02 = edge02;
            Edge03 = edge03;
            P = (edge01 + edge02 + edge03);
            C = P / 2;
            S = Math.Sqrt(C * (C - edge01)* (C - edge02)* (C - edge03));
        }

        public float Edge01 { get; set; }
        public float Edge02 { get; set; }
        public float Edge03 { get; set; }

        public void PTriangle() {
            Console.WriteLine("Perimeter Triangle: {0}",P);
        }
        public void STriangle() {
            Console.WriteLine("Acreage Triangle: {0}", S);
        }
    }
}