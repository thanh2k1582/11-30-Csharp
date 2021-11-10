using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai33
    {
        public class BT33
        {
            public void _33()
            {
                int n,m,q,a=0,s=0,mod,start,end,z=1;
                Console.WriteLine("In day amstrong nam trong khoang la : ");
                Console.WriteLine("So bat dau: ");
                start = Int32.Parse(Console.ReadLine());
                Console.WriteLine("So ket thuc: ");
                end = Int32.Parse(Console.ReadLine());
                for (; start <= end ;start ++ ) {
                    m = start;
                    q = start;
                    for (; m>= 1; )
                    {
                        a += 1;
                        m /= 10;
                    }
                    for (; q >= 1;)
                    {
                        mod = q % 10;
                        q /= 10;
                        for( int j=1; j<= a ;j++ )
                        {
                            z *= mod;
                        }
                        s += z;
                        z = 1;
                    }
                    if (s==start) {
                        Console.Write("{0}   ", start);
                    }
                    s = 0;
                    a = 0;

                }



               

            }
        }
    }
}
