using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Rectangle
    {
        public bool isValidLength() => Length > 0;
        public bool isValidWidth() => Width > 0;
        public float Length { get; set; }
        public float Width { get; set; }

        public float Perimeter() => (Length + Width) / 2;
        public float Acreage() => Length * Width;
    }
}