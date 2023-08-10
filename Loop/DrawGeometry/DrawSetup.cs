using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forLoop
{
    public class Rectangle
    {
        public bool isValidWidth() => Width > 0;
        public bool isValidHeight() => Height > 0;
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public class Triangle
    {
        public bool isValidHeight() => Height > 0;
        public int Height { get; set; }
    }
    public class DiamondShape
    {
        public bool isValidHeight() => (Height > 1 && Height %2 != 0);
        public int Height { get; set;}
    }
}