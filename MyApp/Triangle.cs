using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Triangle
    {
        float canh_01, canh_02, canh_03;
        public Triangle(float x, float y, float z){
            canh_01 = x;
            canh_02 = y;
            canh_03 = z;
        }

        public float Canh_01 {
            get { return canh_01; }
            set {
                if(value > 0) {
                    canh_01 = value;
                }else {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }

        public float Canh_02 {
            get { return canh_02; }
            set {
                if(value > 0) {
                    canh_02 = value;
                }else {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }
        public float Canh_03 {
            get { return canh_01; }
            set {
                if(value > 0) {
                    canh_03 = value;
                }else {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }

        public void ChuViTriangle() {
            Console.WriteLine("Chu vi Tam Giac la: {0}",(canh_01 + canh_02 + canh_03));
        }

        public void DienTichTriangle() {
            double C = (canh_01 + canh_02 + canh_03) / 2;
            double S = Math.Sqrt(C* (C - canh_01)*(C - canh_02)*(C - canh_03));
            Console.WriteLine("Dien tich Tam Giac la: {0}", S);
        }
    }
}