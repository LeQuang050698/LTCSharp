using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forLoop
{
    public class DiamondShape
    {
        public bool isValidHeight() => (Height > 0 && Height %2 != 0);

        public int Height { get; set;}
    }
}