using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai6
    {
        public class BT6
        {
            public void sapXep()
            {
                int a, b, c;
                Console.WriteLine("Nhap so a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so b: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so c: ");
                c = int.Parse(Console.ReadLine());
                int x ;
                if(a < b && a < c && b > c)
                {
                    x = c;
                    c = b;
                    b = x;
                }
                if (b < a && b < c && a < c)
                {
                    x = a;
                    a = b;
                    b = x;
                }
                if (b < a && b < c && c < a)
                {
                    x = a;
                    a = b;
                    b = c;
                    c = x;

                }
                if (c < b && c< a && a <b)
                {
                    x = a;
                    a = c;
                    c = b;
                    b = x;
                }
                if (c < b && c < a && a > b)
                {
                    x = a;
                    a = c;
                    c = x; 
                }
                Console.WriteLine("{0} < {1} < {2} ", a, b, c);
            }
        }
    }
}
