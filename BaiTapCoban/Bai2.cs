using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai2
    {
        public class BT2
        {
            public void khoangCachAB()
            {
                float x1, y1, x2, y2;
                Console.WriteLine("Nhap toa do x1: ");
                x1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y1: ");
                y1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do x2: ");
                x2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap toa do y2: ");
                y2 = float.Parse(Console.ReadLine());
                float s = (float)(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)));
                Console.WriteLine("Khoang cach 2 diem A va B la: {0}", s);
            }
        }
    }
}
