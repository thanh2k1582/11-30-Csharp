using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai28
    {
        public class BT28
        {
            public void hamRound()
            {
                double x_340, x1_340,x2_340;
                Console.WriteLine("Nhap so: ");
                x_340 = double.Parse(Console.ReadLine());
                int n_340, y_340, z_340 = 1;
                Console.WriteLine("Nhap thu tu n muon lam tron");
                n_340 = Int32.Parse(Console.ReadLine());
                if (n_340 == 0)
                {
                    y_340 = (int)x_340;
                    if (y_340 == 0)
                    {
                        if (x_340 < 0)
                        {
                            y_340 -= 1;
                        }
                        else
                        {
                            if(x_340 == 0)
                            {
                                y_340 = 0;
                            }
                            else
                            {
                                y_340 += 1;
                            }
                        }
                    }
                    else
                    {
                        if(y_340 > 0)
                        {
                            y_340 += 1;
                        }
                        else
                        {
                            y_340 -= 1;
                        }
                    }
                    Console.WriteLine("so {0} sau khi duoc lam tron chinh xac {1} chu so se la: {2}", x_340, n_340, y_340);

                }
                else
                {
                    if (n_340 < 0)
                    {
                        y_340 = (int)x_340;
                        for(int i_340 = -1; i_340 >= n_340; i_340--) {
                            if (i_340 == n_340) {
                                z_340 *= 10;

                                y_340 = y_340 / z_340;
                                int t_340 = y_340 % 10;
                                if (t_340 >= 5)
                                {
                                    y_340 = (y_340 + 1) * z_340;
                                    Console.WriteLine("{0}", y_340);
                                }
                                else
                                {
                                    y_340 = y_340 * z_340;
                                    Console.WriteLine("{0}", y_340);
                                }
                            }
                            else
                            {
                                z_340 *= 10;
                                y_340 = y_340 / z_340;
                                y_340 = y_340 * z_340;
                            }
                        }
                    }
                    else
                    {
                        x1_340 = x_340;
                        x2_340 = x_340;
                        for(int i_340 = 1; i_340 <= n_340; i_340++)
                        {
                            z_340 *= 10;
                            if(i_340 == n_340)
                            {
                                x1_340 *= z_340;
                                x2_340 *= z_340 * 10;
                                int t = (int)x2_340 % 10;
                                if (t >= 5)
                                {
                                    y_340 = (int)x1_340;
                                    x1_340 = (double)(y_340 + 1) / z_340;
                                    Console.WriteLine("{0}", x1_340);
                                }
                                else
                                {
                                    y_340 = (int)x1_340;
                                    x1_340 = (double)y_340/ z_340;
                                    Console.WriteLine("{0}", x1_340);
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
