using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramMath
{
    public class FirstEquation
    {
        public bool isValidA() => A != 0;
        public float A { get; set; }
        public float B { get; set; }
        public float X => -B / A;
    }

    public class SetQuadratic
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public double Delta => B*B - 4*A*C;
        public double X => (-B) / (2 * A);
        public double X1 => (-B + Math.Sqrt(Delta)) / (2 * A);
        public double X2 => (-B - Math.Sqrt(Delta)) / (2 * A); 
    }
}