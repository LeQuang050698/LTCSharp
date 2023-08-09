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
}