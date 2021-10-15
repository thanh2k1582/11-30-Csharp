using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai3
    {
        public class BT3
        {
            public void xdDiemM()
            {
                float x1, y1, R, x2, y2;
                Console.WriteLine("Nhap toa do diem x cua tam duong tron: ");
                x1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do diem y cua tam duong tron: ");
                y1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap do dai ban kinh cua duong tron : ");
                R = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do x cua diem M: ");
                x2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y cua diem M: ");
                y2 = float.Parse(Console.ReadLine());
                float s = (float)(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
                Console.WriteLine("Khoang cach tu diem M den tam duong tron la: {0}", s);
                if(s > R)
                {
                    Console.WriteLine("M nam ngoai duong tron C");
                }
                else
                {
                    if(s == R)
                    {
                        Console.WriteLine("M nam tren duong tron C");
                    }
                    Console.WriteLine("M nam trong duong tron C");
                }
            }
        }
    }
}
