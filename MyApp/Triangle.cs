using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Triangle
    {
        private float edge01;
        private float edge02;
        private float edge03;
        public Triangle(float edge01, float edge02, float edge03){
            FirstEdge = edge01;
            SecondEdge = edge02;
            ThirdEdge = edge03;
        }

        public float FirstEdge { 
            get { return edge01; }
            set {
                if(value > 0) {
                    edge01 = value;
                }else {
                    Console.WriteLine("Please Re-Enter!");
                    do {
                        Console.WriteLine("The First Side Of The Triangle: ");
                        value = Convert.ToSingle(Console.ReadLine());
                        if(value > 0) {
                            edge01 = value;
                        } else {
                            Console.WriteLine("Please Re-Enter!");
                        }
                    }while(value <=0 );
                }
            }
        }
        public float SecondEdge { 
            get { return edge02; }
            set {
                if(value > 0) {
                    edge02 = value;
                }else {
                    Console.WriteLine("Please Re-Enter!");
                    do {
                        Console.WriteLine("The Second Side Of The Triangle: ");
                        value = Convert.ToSingle(Console.ReadLine());
                        if(value > 0) {
                            edge02 = value;
                        } else {
                            Console.WriteLine("Please Re-Enter!");
                        }
                    }while(value <=0 );
                }
            }
        }
        public float ThirdEdge { 
            get { return edge03; }
            set {
                if(value > 0) {
                    edge03 = value;
                }else {
                    Console.WriteLine("Please Re-Enter!");
                    do {
                        Console.WriteLine("The Third Side Of The Triangle: ");
                        value = Convert.ToSingle(Console.ReadLine());
                        if(value > 0) {
                            edge03 = value;
                        } else {
                            Console.WriteLine("Please Re-Enter!");
                        }
                    }while(value <=0 );
                }
            }
        }

        public void CalculateTria() {
            float P,C;
            double S;
            P = FirstEdge + SecondEdge + ThirdEdge;
            C = P / 2;
            S = Math.Sqrt(C*(C-FirstEdge)*(C-SecondEdge)*(C-ThirdEdge));
            if(FirstEdge >= SecondEdge + ThirdEdge || SecondEdge >= FirstEdge + ThirdEdge || ThirdEdge >= FirstEdge + SecondEdge) {
                Console.WriteLine("This is not a triangle");
            } else {
                Console.WriteLine("Perimeter Triangle: {0}",P);
                Console.WriteLine("Acreage Triangle: {0}",S); 
            }
        }
    }
}