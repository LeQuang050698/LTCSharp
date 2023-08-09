using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Triangle
    {
        public bool isValidFirstEdge() => FirstEdge > 0;
        public bool isValidSecondEdge() => SecondEdge > 0;
        public bool isValidThirdEdge() => ThirdEdge > 0;
        public bool isValidTriangle() => (FirstEdge >= SecondEdge + ThirdEdge || SecondEdge >= FirstEdge + ThirdEdge || ThirdEdge >= FirstEdge + SecondEdge);

        public float FirstEdge { get; set; }
        public float SecondEdge { get; set; }
        public float ThirdEdge { get; set; }

        public float Perimeter() => FirstEdge + SecondEdge + ThirdEdge;
        public double Acreage() => Math.Sqrt((Perimeter()/2)*((Perimeter()/2)-FirstEdge)*((Perimeter()/2)-SecondEdge)*((Perimeter()/2)-ThirdEdge));
    }
}