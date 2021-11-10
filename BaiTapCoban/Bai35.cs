using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai35
    {
        public class BT35
        {
            public void _35()
            {
                int n;
                int y = 0,z=0;

                Console.WriteLine("Nhap so nguyen n: ");
                n = Int32.Parse(Console.ReadLine());
                for(int i = 2; i< Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        y += 1;
                    }
                    
                }
                if(y == 0)
                {
                    Console.WriteLine("n  = {0} la so nguyen to",n);
                }
                else
                {
                    Console.WriteLine("n = {0} khong phai la so nguyen to",n);
                    for (; n > 0; n--)
                    {
                        for (int j = 2; j < (n); j++)
                        {
                            if (n % j == 0)
                            {
                                z += 1;
                            }

                        }
                        if (z == 0)
                        {
                            Console.WriteLine("{0} la so nguyen to nho gan nhat so voi n = {1}", n, n);
                            n = 0;
                        }
                        z = 0;
                    }
                }
            }
        }
    }
}
