using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai23
    {
        public class BT23
        {
            public void soHoanhao() {
                int soNguyen_340;
                Console.Write("Nhap so nguyen: ");
                soNguyen_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Cac so hoan hao nho hon {0} la \n", soNguyen_340);
                for (int j_340 = 1; j_340 < soNguyen_340; j_340++) {
                    int tong_340 = 0;
                    for (int i_340 = 1; i_340 < j_340; i_340++)
                    {
                        if (j_340 % i_340 == 0)
                        {
                            tong_340 += i_340;
                            if (tong_340 == j_340 && i_340 == (j_340 / 2))
                            {
                                Console.Write("{0}     ", j_340);
                            }
                        }
                        
                    }
                    
                }
            }
        }
    }
}
