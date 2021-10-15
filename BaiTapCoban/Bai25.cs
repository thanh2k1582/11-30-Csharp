using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai25
    {
        public class BT25
        {
            public void uocSoBoiSo()
            {
                int a_340, b_340;
                Console.WriteLine("Nhap vao 2 so nguyen duong a b ");
                Console.Write("a: ");
                a_340 = Int32.Parse(Console.ReadLine());
                Console.Write("b: ");
                b_340 = Int32.Parse(Console.ReadLine());
                int c_340 = 0;
                int d_340 = 0;
                if (a_340 < b_340)
                {
                    c_340 = a_340;
                    for (; c_340 > 0; --c_340)
                    {
                        if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                        {
                            Console.WriteLine("{0} la uoc so chung lon nhat", c_340);
                            break;
                        }
                    }
                }
                else
                {
                    c_340 = b_340;
                    for (; c_340 > 0; --c_340)
                    {
                        if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                        {
                            Console.WriteLine("{0} la uoc so chung lon nhat", c_340);
                            break;
                        }
                    }
                }
                if (a_340 < b_340)
                {
                    d_340 = b_340;
                    for (; ; d_340++)
                    {
                        if (d_340 % a_340 == 0 && d_340 % b_340 == 0)
                        {
                            Console.WriteLine("{0} la boi so chung nho nhat", d_340);
                            break;
                        }
                    }
                }
                else
                {
                    d_340 = a_340;
                    for (; ; d_340++)
                    {
                        if (d_340 % a_340 == 0 && d_340 % b_340 == 0)
                        {
                            Console.WriteLine("{0} la boi so chung nho nhat", d_340);
                            break;
                        }
                    }
                }


            }
        }
    }
}
