using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai26
    {
        public class BT26
        {
            public void toiGian()
            {
                int a_340, b_340, c_340 = 0, d_340;
                Console.WriteLine("Nhap vao tu so va mau so ");
                Console.Write("tu so: ");
                a_340 = Int32.Parse(Console.ReadLine());
                Console.Write("mau so: ");
                b_340 = Int32.Parse(Console.ReadLine());
                
                if(a_340 < 0 && b_340 > 0)
                {
                    a_340 = -a_340;
                    if (a_340 < b_340)
                    {
                        c_340 = a_340;
                        for (; c_340 > 0; --c_340)
                        {
                            if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                            {
                                a_340 = -a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
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
                                a_340 = -a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                break;
                            }
                        }
                    }
                }
                //
                if (a_340 > 0 && b_340 < 0)
                {
                    b_340 = -b_340;
                    if (a_340 < b_340)
                    {
                        c_340 = a_340;
                        for (; c_340 > 0; --c_340)
                        {
                            if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                            {
                                a_340 = -a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
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
                                a_340 = -a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                break;
                            }
                        }
                    }
                }
                //
                if (a_340 > 0 && b_340 > 0)
                {
                    if (a_340 < b_340)
                    {
                        c_340 = a_340;
                        for (; c_340 > 0; --c_340)
                        {
                            if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                            {
                                a_340 = a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (a_340 % b_340 == 0)
                        {
                            Console.WriteLine("phan so sau khi rut gon la: {0}", a_340 / b_340);
                        }
                        else
                        {
                            c_340 = b_340;
                            for (; c_340 > 0; --c_340)
                            {
                                if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                                {
                                    a_340 = a_340 / c_340;
                                    b_340 /= c_340;
                                    Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                    break;
                                }
                            }
                        }
                    }
                }
                //
                if (a_340 < 0 && b_340 < 0)
                {
                    a_340 = -a_340;
                    b_340 = -b_340;
                    if (a_340 < b_340)
                    {
                        c_340 = a_340;
                        for (; c_340 > 0; --c_340)
                        {
                            if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                            {
                                a_340 = a_340 / c_340;
                                b_340 /= c_340;
                                Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (a_340 % b_340 == 0)
                        {
                            Console.WriteLine("phan so sau khi rut gon la: {0}", a_340 / b_340);
                        }
                        else
                        {
                            c_340 = b_340;
                            for (; c_340 > 0; --c_340)
                            {
                                if (a_340 % c_340 == 0 && b_340 % c_340 == 0)
                                {
                                    a_340 = a_340 / c_340;
                                    b_340 /= c_340;
                                    Console.WriteLine("phan so sau khi rut gon la: {0}/{1}", a_340, b_340);
                                    break;
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
