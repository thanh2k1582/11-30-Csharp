using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai7
    {
        public class BT7
        {
            public void pt1()
            {
                float a, b;
                Console.WriteLine("nhap a: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("nhap b: ");
                b = float.Parse(Console.ReadLine());
                if(a == 0 && b == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                }
                if(a != 0 && b != 0) {
                    Console.WriteLine("phuong trinh co nghiem la: {0}",-b/a);
                }
                if(a != 0 && b == 0)
                {
                    Console.WriteLine("phuong trinh co nghiem x = 0");
                }
                if(a ==0 && b != 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }

            }
        }
    }
}
