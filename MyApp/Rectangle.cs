using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Rectangle {
        private float length;
        private float width;
        public Rectangle(float length, float width) {
            Length = length;
            Width = width;
        }

        public float Length { 
            get { return length; }
         
            set {
                if(value > 0) {
                    length = value;
                } else {
                    Console.WriteLine("Please Re-Enter!");
                    
                    do {
                        Console.WriteLine("Length Rectangle: ");
                        value = Convert.ToSingle(Console.ReadLine());
                        if(value > 0) {
                            length = value;
                        }else {
                            Console.WriteLine("Please Re-Enter!");
                        }
                    }while(value <= 0);
                }
            }
        }
        public float Width {
            get { return width; }
         
            set {
                if(value > 0) {
                    width = value;
                }else {
                    Console.WriteLine("Please Re-Enter!");

                    do {
                        Console.WriteLine("Width Rectangle: ");
                        value = Convert.ToSingle(Console.ReadLine());
                        if(value > 0) {
                            width = value;
                        }else {
                            Console.WriteLine("Please Re-Enter!");
                        }

                    }while(value <= 0);
                }
            }
        }

        public void CalculateRec() {
            float P,S;
            P = (Length + Width) / 2;
            S = Length * Width;
            Console.WriteLine("Perimeter Rectangle: {0}",P); 
            Console.WriteLine("Acreage Rectangle: {0}",S);
        }
    }
}