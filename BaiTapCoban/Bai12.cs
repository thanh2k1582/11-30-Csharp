using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai12
    {
        public class BT12
        {
            public void pt2an()
            {
                int a1_340, a2_340, b1_340, b2_340, c1_340, c2_340;
                Console.WriteLine("Nhap gia tri lan luot a1 , b1 , c1 ");
                Console.Write("a1 = ");
                a1_340 = Int32.Parse(Console.ReadLine());
                Console.Write("b1 = ");
                b1_340 = Int32.Parse(Console.ReadLine());
                Console.Write("c1 = ");
                c1_340 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia tri lan luot a2 , b2 , c2");
                Console.Write("a2 = ");
                a2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("b2 = ");
                b2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("c2 = ");
                c2_340 = Int32.Parse(Console.ReadLine());
                float D_340 = a1_340 * b2_340 - a2_340 * b1_340;
                float Dx_340 = c1_340 * b2_340 - c2_340 * b1_340;
                float Dy_340 = a1_340 * c2_340 - a2_340 * c1_340;
                if(D_340 == 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh co nghiem x = {0} va y = {1}", Dx_340 / D_340, Dy_340 / D_340);
                }
            }
        }
    }
}
