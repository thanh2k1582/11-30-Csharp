using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai8
    {
        public class BT8
        {
            public void pt2()
            {
                float a, b, c;
                Console.WriteLine("Nhap a: ");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap b: ");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap c: ");
                c = float.Parse(Console.ReadLine());
                float delta = (float)(b*b-4*a*c);
                float x1 = (float)(((-b + Math.Sqrt(delta)) /(2*a)));
                float x2 = (float)(((-b - Math.Sqrt(delta)) /(2*a)));
                if(a == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x = {0}", -c / b);
                }
                else
                {
                    if (delta > 0)
                    {
                        Console.WriteLine("Phuong trinh co 2 nghiem x1 x2 lan luot la: {0} \n {1}", x1, x2);
                    }
                    else
                    {
                        if (delta == 0)
                        {
                            Console.WriteLine("Phuong trinh co nghiem kep x1= x2 = {0}", -b / (2 * a));
                        }
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
            }
        }
    }
}
