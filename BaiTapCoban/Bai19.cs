using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai19
    {
        public class BT19
        {
            public void khoangTG()
            {
                int giay_340 , phut_340 , gio_340 ,ngay_340, thang_340, nam_340;
                int giay2_340 , phut2_340 , gio2_340 ,ngay2_340, thang2_340, nam2_340;
                Console.WriteLine("Nhap khoang thoi gian lan 1");
                Console.Write("nam: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                Console.Write("thang: ");
                thang_340 = Int32.Parse(Console.ReadLine());
                Console.Write("ngay: ");
                ngay_340 = Int32.Parse(Console.ReadLine());
                Console.Write("gio: ");
                gio_340 = Int32.Parse(Console.ReadLine());
                Console.Write("phut: ");
                phut_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Giay: ");
                giay_340 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nhap khoang thoi gian lan 2");
                Console.Write("nam: ");
                nam2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("thang: ");
                thang2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("ngay: ");
                ngay2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("gio: ");
                gio2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("phut: ");
                phut2_340 = Int32.Parse(Console.ReadLine());
                Console.Write("giay: ");
                giay2_340 = Int32.Parse(Console.ReadLine());
                int sogio_340, sophut_340, sogiay_340,songay_340,sonam_340,sothang_340,x_340;
                if(nam_340 > nam2_340)
                {
                    x_340 = nam_340;
                    nam_340 = nam2_340;
                    nam2_340 = x_340;
                    x_340 = thang_340;
                    thang_340 = thang2_340;
                    thang2_340 = x_340;
                    x_340 = ngay_340;
                    ngay_340 = ngay2_340;
                    ngay2_340 = x_340;
                    x_340 = gio_340;
                    gio_340 = gio2_340;
                    gio2_340 = x_340;
                    x_340 = phut_340;
                    phut_340 = phut2_340;
                    phut2_340 = x_340;
                    x_340 = giay_340;
                    giay_340 = giay2_340;
                    giay2_340 = x_340;

                }
                if(nam_340 < nam2_340)
                {
                    sonam_340 = nam2_340 - nam_340 - 1;
                    sothang_340 = 12 - thang_340 + thang2_340; 
                    if (thang_340 == 1 || thang_340 == 5 || thang_340 == 3 || thang_340 == 7 || thang_340 == 8 || thang_340 == 10 || thang_340 == 12)
                    {
                        songay_340 = 31 - ngay_340 + ngay2_340;
                    }
                    else
                    {
                        if (thang_340 == 4 || thang_340 == 6 || thang_340 == 9 || thang_340 == 11)
                        {
                            songay_340 = 30 - ngay_340 + ngay2_340;
                        }
                        else
                        {
                            if (thang_340 == 2 && nam_340 % 4 == 0)
                            {
                                songay_340 = 29 - ngay_340 + ngay2_340;
                            }
                            else
                            {
                                songay_340 = 28 - ngay_340 + ngay2_340;
                            }
                        }
                    }
                    sophut_340 = 60 - phut_340 + phut2_340;
                    sogio_340 = 24 - gio_340 + gio2_340;
                    sogiay_340 = 60 - giay_340 + giay2_340;
                    if (sogiay_340 >= 60)
                    {
                        sogiay_340 -= 60;
                        sophut_340 += 1;
                    }
                    if (sophut_340 >= 60)
                    {
                        sophut_340 -= 60;
                        sogio_340 += 1;
                    }
                    if (sogio_340 >= 24)
                    {
                        sogio_340 -= 24;
                        songay_340 += 1;
                    }
                    if (songay_340 >= 30)
                    {
                        songay_340 -= 30;
                        sothang_340 += 1;
                    }
                    if (sothang_340 >= 12)
                    {
                        sothang_340 -= 12;
                        sonam_340 += 1;
                    }
                    Console.WriteLine("Hieu thoi gian:{0} nam {1} thang {2} ngay {3} gio {4} phut {5} giay", sonam_340, sothang_340,songay_340,sogio_340,sophut_340,sogiay_340);

                }


            }
        }
    }
}
