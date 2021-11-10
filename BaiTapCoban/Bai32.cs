using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai32
    {
        public class BT32
        {
            public void _32()
            {
                int n,m=0;
                Console.WriteLine("Nhap so nguyen n cho chuoi hailstones: ");
                n = Int32.Parse(Console.ReadLine());
                Console.Write("{0}   ", n);
                do
                {
                    if( m != 5)
                    {
                        if (n % 2 == 1)
                        {
                            n = 3 * n + 1;
                            m += 1;
                        }
                        else
                        {
                            n /= 2;
                            m += 1;
                        }
                        Console.Write("{0}   ", n);
                    }
                    else
                    {
                        if (n % 2 == 1)
                        {
                            n = 3 * n + 1;
                            m = 0;
                        }
                        else
                        {
                            n /= 2;
                            m = 0;
                        }
                        Console.WriteLine("{0}   ", n);
                    }
                }
                while (n != 1);
            }
        }
    }
}
