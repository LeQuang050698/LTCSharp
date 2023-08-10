using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifElse
{
    public class Rectangle
    {
        public bool isValidLength() => Length > 0;
        public bool isValidWidth() => Width > 0;
        public float Length {get;set;}
        public float Width {get;set;}
        public float Perimeter => (Length + Width) / 2;
        public float Acreage => Length * Width;
    }

    public class Circle
    {
        public bool isValidRadius() => Radius > 0;
        public float Radius {get;set;}
        public double Pi => Math.PI;
        public double Perimeter => (2 * Radius) * Pi;
        public double Acreage => Math.Pow(Radius, 2) * Pi;
    }

    public class Triangle
    {
        public bool isValidFirstEdge() => FirstEdge > 0;
        public bool isValidSecondEdge() => SecondEdge > 0;
        public bool isValidThirdEdge() => ThirdEdge > 0;
        public bool isValidTriangle() => (FirstEdge >= SecondEdge + ThirdEdge || SecondEdge >= FirstEdge + ThirdEdge || ThirdEdge >= FirstEdge + SecondEdge);
        public bool isValidIsoscelesTriangle() => (FirstEdge == ThirdEdge || FirstEdge == SecondEdge || SecondEdge == ThirdEdge);
        public bool isValidEquilateralTriangle() => (FirstEdge == SecondEdge && SecondEdge == ThirdEdge);
        public bool isValidRightTriangle() => ((PowFirstEdge == PowSecondEdge + PowThirdEdge) || (PowSecondEdge == PowFirstEdge + PowThirdEdge) || (PowThirdEdge == PowFirstEdge + PowSecondEdge));
        public float FirstEdge {get;set;}
        public double PowFirstEdge => FirstEdge*FirstEdge;
        public float SecondEdge {get;set;}
        public double PowSecondEdge => SecondEdge*SecondEdge;
        public float ThirdEdge {get;set;}
        public double PowThirdEdge => ThirdEdge*ThirdEdge;
        public float Perimeter => FirstEdge + SecondEdge + ThirdEdge;
        public double Acreage => Math.Sqrt((Perimeter/2)*((Perimeter/2) - FirstEdge)*((Perimeter/2) - SecondEdge)*((Perimeter/2)-ThirdEdge));
    }
}