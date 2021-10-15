using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai4
    {
        public class BT4
        {
            public void tamgiac()
            {
                float a, b, c;
                int x = 1;
                do {
                    Console.WriteLine("do dai 3 canh phai la 1 so duong lon hon 0 , xin moi nhap: ");
                    Console.WriteLine("Nhap do dai canh thu nhat : ");
                    a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap do dai canh thu hai : ");
                    b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap do dai canh thu ba : ");
                    c = float.Parse(Console.ReadLine());
                }
                while (a<=0 || b<=0 || c<= 0);
                if ( a == b && b == c)
                {
                    Console.WriteLine("day la tam giac deu");
                }
                if (a*a + b*b == c*c || b * b == c * c +a*a || a * a == b * b * c * c) {
                    Console.WriteLine("Day la tam giac vuong");
                }
                if (a * a + b * b == c * c && a == b || b * b == c * c + a * a && c == a|| a * a == b * b * c * c && b==c)
                {
                    Console.WriteLine("Day la tam giac vuong can");
                }
                if (a * a + b * b < c * c || b * b > c * c + a * a || a * a > b * b * c * c)
                {
                    Console.WriteLine("Day la tam giac tu");
                }
                else
                {
                    Console.WriteLine("Day la tam giac nhon");
                }
                float p = (float)((a + b + c) / 2);
                float s = (float)(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
                Console.WriteLine("dien tich tam giac la: {0}", s);
            }
        }
    }
}
