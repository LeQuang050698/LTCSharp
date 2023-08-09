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

        public void CalculateTriangle() {
            float P = FirstEdge + SecondEdge + ThirdEdge;
            float C = P / 2;
            double S = Math.Sqrt(C*(C - FirstEdge)*(C - SecondEdge)*(C - ThirdEdge));

            Console.WriteLine($"Perimeter Triangle: {P}");
            Console.WriteLine($"Acreage Triangle: {S}");
        }
    }
}