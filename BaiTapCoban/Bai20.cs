using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai20
    {
        public class BT20
        {
            public void tienDien()
            {
                int soKW_340;
                int soTien_340 = 0;
                soKW_340 = Int32.Parse(Console.ReadLine());
                for(int i_340 = 1; i_340 <= soKW_340; i_340++)
                {
                    if (i_340 <= 100)
                    {
                        soTien_340 += 500;
                    }
                    else
                    {
                        if(i_340 > 100 && i_340 <= 250)
                        {
                            soTien_340 += 800;
                        }
                        else
                        {
                            if(i_340 > 250 && i_340 <= 350)
                            {
                                soTien_340 += 1000;
                            }
                            else
                            {
                                soTien_340 += 1500;
                            }
                        }
                    }
                }
                Console.WriteLine("So tien dien phai tra la: {0} vnd", soTien_340);
            }
        }
    }
}
