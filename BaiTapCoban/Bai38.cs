using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai38
    {
        public class BT38
        {
            public void _38()
            {
                int n,a=0,b=0,c=0;
                do
                {
                    Console.WriteLine("Nhap so tien n(nghin dong,n>5) nguyen duong ");
                    n = Int32.Parse(Console.ReadLine());
                    if (n > 5) {
                        if ((n % 5) % 2 == 1)
                        {
                            a = 1;
                            n -= 1;
                            for (; n > 0;)
                            {
                                if (n >= 7)
                                {
                                    b += 1;
                                    n -= 2;
                                    c += 1;
                                    n -= 5;
                                }
                                else
                                {
                                    b += 1;
                                    n -= 2;
                                }

                            }
                            Console.WriteLine("{0} - {1} - {2}", a, b, c);

                        }
                        else
                        {
                            a = 0;
                            for (; n > 0;)
                            {
                                if (n >= 7)
                                {
                                    b += 1;
                                    n -= 2;
                                    c += 1;
                                    n -= 5;
                                }
                                else
                                {
                                    b += 1;
                                    n -= 2;
                                }

                            }
                            Console.WriteLine("{0} - {1} - {2}", a, b, c);

                        }
                    }
                }
                while (n%1 != 0 || n <= 5);

            }
        }
    }
}
