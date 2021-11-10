using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai37
    {
        public class BT37
        {
            public void _Bai37()
            {
                int n,s=0;
                Console.WriteLine("nhap so nguyen duong n : ");
                n = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    s += i;
                    if(s + i + 1 >= n)
                    {
                        Console.Write("{0}", i);
                        break;
                    }
                    Console.Write("{0} + ", i);

                };
                Console.Write(" = {0} < {1}" , s,n);

            }
        }
    }
}
