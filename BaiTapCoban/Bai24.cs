using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai24
    {
        public class BT24
        {
            public void soNgauNhien()
            {
                long soNguyen_340;
                long a_340;
                Console.Write("Nhap so nguyen: ");
                soNguyen_340 = long.Parse(Console.ReadLine());
                a_340 = soNguyen_340;
                int soChuSo_340 = 1;
                Console.Write("{0} co ",soNguyen_340);
                if(soNguyen_340 >= 10)
                {
                    do
                    {
                        soChuSo_340 += 1;
                        soNguyen_340 /= 10;
                    }
                    while (soNguyen_340 > 9);
                    Console.WriteLine("{0} chu so" ,soChuSo_340);
                }
                else
                {
                    Console.WriteLine("{0} chu so", soChuSo_340);
                }
                int soCuoi_340 = (int)(a_340 % 10);
                Console.WriteLine("So cuoi cung la: {0}",soCuoi_340);
                long soDau_340 = a_340;
                if(soDau_340 < 10)
                {
                    Console.WriteLine("So dau tien la: {0}", soDau_340);
                }
                else
                {
                    do
                    {
                        soDau_340 /= 10;
                    }
                    while (soDau_340 >= 10);
                    Console.WriteLine("So dau tien la: {0}", soDau_340);

                }
                long soDaoNguoc_340 = a_340;
                long so1_340, so2_340=0;
                do {
                    so1_340 = soDaoNguoc_340 % 10;
                    soDaoNguoc_340 /= 10;

                    if (a_340 < 10)
                    {
                        so2_340 = a_340;
                    }
                    else
                    {
                        so2_340 = so2_340 * 10 + so1_340;
                    }
                } 
                while (soDaoNguoc_340 > 0);
                Console.Write("So dao nguoc la {0}", so2_340);

            }
        }
    }
}
