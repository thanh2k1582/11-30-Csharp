using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai22
    {
        public class BT22
        {
            public void uocSo()
            {
                int soNguyen_340;
                Console.Write("Nhap so nguyen: ");
                soNguyen_340 = Int32.Parse(Console.ReadLine());
                int uoc_340 = 0;
                int tong_340 = 0;
                for(int i_340 = 1; i_340 <= soNguyen_340; i_340++)
                {
                    if(soNguyen_340 % i_340 == 0)
                    {
                        Console.Write(" {0} ", i_340);
                        tong_340 += i_340;
                        uoc_340 += 1;
                    }
                }
                Console.WriteLine("\nCo {0} uoc so , tong la {1}", uoc_340, tong_340);
            }
        }
    }
}
