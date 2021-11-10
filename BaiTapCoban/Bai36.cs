using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai36
    {
        public class BT36
        {
            public void _36()
            {
                int n,m=0,z=0;
                Console.WriteLine("Nhap n so nguyen to ban can in: ");
                n = Int32.Parse(Console.ReadLine());
                for (int i = 2; i>0 ;i ++ )
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            m += 1;
                        }
                    }
                    if (m == 1)
                    {

                        Console.Write("{0}   ", i);
                        z += 1;
                    }
                    m = 0;
                    if (z == n)
                    {
                        i = -1;
                    }

                }
            }
        }
    }
}
