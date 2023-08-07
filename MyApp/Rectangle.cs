using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    class Rectangle {
        float chieiDai, chieuRong;

        public Rectangle(float width, float height) {
            chieiDai = width;
            chieuRong = height;
        }

        public float ChieuDai {
            get { return chieiDai; }
            set {
                if(value > 0) {
                    chieiDai = value;
                }else {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }
        public float ChieuRong {
            get { return chieuRong; }
            set {
                if(value > 0) {
                    chieuRong = value;
                }else {
                    Console.WriteLine("Vui long nhap lai");
                }
            }
        }

        public void ChuViRectangle() {
            Console.WriteLine("Chu vi HCN la: {0}",(chieiDai + chieuRong)/2);
        }

        public void DienTichRectangle() {
            Console.WriteLine("Dien tich HCN la: {0}",(chieiDai * chieuRong));
        }
        
    }
}