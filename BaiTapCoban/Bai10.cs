using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai10
    {
        public class BT10
        {
            public void SIN()
            {
                int sbh_340, x_340;
                int num_340 = 0;
                do
                {
                    num_340 = 0;
                    Console.WriteLine("Nhap so bao hiem gom 9 chu so: ");
                    sbh_340 = Int32.Parse(Console.ReadLine());
                    x_340 = sbh_340;
                    for (int i_340 = 1; i_340 <= x_340;)
                    {
                        num_340 += 1;
                        x_340 /= 10;
                    }

                }
                while (num_340 != 9);
                int checkDigit_340 = sbh_340 % 10;
                int shb2_340 = sbh_340 / 10;
                int sum1_340 = 0, sum2_340 = 0, mod1_340, mod2_340;
                for (int i_340 = 1; i_340 <= 8; i_340++)
                {
                    if (i_340 % 2 == 1)
                    {
                        mod1_340 = (shb2_340 % 10)*2;
                        if(mod1_340 >= 10)
                        {
                            mod1_340 = mod1_340 % 10 + mod1_340 / 10;
                        }
                        sum1_340 += mod1_340;
                    }
                    else
                    {
                        mod2_340 = shb2_340 % 10;
                        sum2_340 += mod2_340;
                    }
                    shb2_340 /= 10;
                }
                int sum_340 = checkDigit_340 + sum1_340 + sum2_340;
                Console.WriteLine("{0}", sum_340);
                if (sum_340 % 10 == 0)
                {
                    Console.WriteLine("SIN hop le");
                }
                else
                {
                    Console.WriteLine("SIN khong hop le");
                }

            }
        }
    }
}
