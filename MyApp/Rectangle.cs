using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Rectangle {
        float S,P;
        public Rectangle(float length, float width) {
            Length = length;
            Width = width;
            P = (length + width) / 2;
            S = (length * width);
        }

        public float Length { get; set; }
        public float Width { get; set; }
        public void PRectangle() {
            Console.WriteLine("Perimeter Rectangle: {0}",P);
        }

        public void SRectangle() {
            Console.WriteLine("Acreage Rectangle: {0}", S);
        }
    }
}