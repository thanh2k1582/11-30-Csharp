using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai15
    {
        public class BT15
        {
            public void ngayTrongNam()
            {
                int ngay_340, thang_340, nam_340;
                Console.Write("Ngay: ");
                ngay_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Thang: ");
                thang_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Nam: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                int sumday_340 = ngay_340;
                for (int i_340 = 0; i_340 < thang_340; i_340++)
                {
                    if(i_340 == 1 || i_340 == 3 || i_340 == 5 || i_340 == 7 || i_340 == 8 || i_340 == 10 || i_340 == 12) {
                        sumday_340 += 31;
                    }
                    if (i_340 == 4 || i_340 == 6 || i_340 == 9 || i_340 == 11)
                    {
                        sumday_340 += 30;
                    }
                    if(i_340 == 2)
                    {
                        if(nam_340 % 4 == 0)
                        {
                            sumday_340 += 29;
                        }
                        else
                        {
                            sumday_340 += 28;
                        }
                    }

                }
                Console.WriteLine("Ngay {0} thang {1} nam {2} la ngay thu {3} trong nam", ngay_340, thang_340, nam_340, sumday_340);
            }
        }
    }
}
