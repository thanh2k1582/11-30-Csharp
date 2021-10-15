using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai5
    {
        public class BT5
        {
            public void toaDoTamGiac()
            {
                float x1, x2, x3, y1, y2, y3, m1, m2;
                Console.WriteLine("Nhap toa do x cua diem A: ");
                x1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y cua diem A: ");
                y1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do x cua diem B: ");
                x2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y cua diem B: ");
                y2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do x cua diem C: ");
                x3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y cua diem C: ");
                y3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do x cua diem M: ");
                m1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y cua diem M: ");
                m2 = float.Parse(Console.ReadLine());
                float sABC = (float)(Math.Abs((x1 * y2 - x2 * y1 + x2 * y3 - x3 * y2 + x3 * y1 - x1 * y3)) /2);
                float sMBC = (float)(Math.Abs(m1 * y2 - x2 * m2 + x2 * y3 - x3 * y2 + x3 * m2 - m1 * y3) / 2);
                float sMAB = (float)(Math.Abs(m1 * y1 - x1 * m2 + x1 * y2 - x2 * y1 + x2 * m2 - m1 * y2) / 2);
                float sMCA = (float)(Math.Abs(m1 * y3 - x3 * m2 + x3 * y1 - x1 * y3 + x1 * m2 - m1 * y1) / 2);
                float sumS = (float)(sMAB+sMBC+sMCA);
                if (sABC == sumS) {
                    Console.WriteLine("M nam tren canh tam giac ABC");
                }
                else
                {
                    if(sABC > sumS)
                    {
                        Console.WriteLine("M nam ngoai tam giac ABC");
                    }
                    Console.WriteLine("M nam trong tam giac ABC");
                }

            }
        }
    }
}
