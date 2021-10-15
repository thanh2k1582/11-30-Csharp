using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai14
    {
        public class BT14
        {
            public void ngayKeTiep()
            {
                int ngay_340, thang_340, nam_340;
                Console.Write("Ngay: ");
                ngay_340 = Int32.Parse(Console.ReadLine());
                Console.Write("thang: ");
                thang_340 = Int32.Parse(Console.ReadLine());
                Console.Write("nam: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                int ngayTruoc_340, thangTruoc_340, namTruoc_340;
                switch (thang_340) {
                    
                    case 1: 
                        ngayTruoc_340 = ngay_340;
                        if(ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = 12;
                            namTruoc_340 = nam_340 - 1;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340,thangTruoc_340,namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                            break;
                    case 3:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            if (nam_340 % 4 == 0)
                            {
                                ngayTruoc_340 = 29;
                                thangTruoc_340 = thang_340 - 1;
                                namTruoc_340 = nam_340;
                            }
                            else
                            {
                                ngayTruoc_340 = 28;
                                thangTruoc_340 = thang_340 - 1;
                                namTruoc_340 = nam_340;
                            }
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 5:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 30;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 7:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 30;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 8:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 10:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 30;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 12:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 30;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 31)
                        {
                            ngay_340 = 1;
                            thang_340 = 1;
                            nam_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 4:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 30)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 6:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 30)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 9:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 30)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 11:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (ngay_340 == 30)
                        {
                            ngay_340 = 1;
                            thang_340 += 1;
                        }
                        else
                        {
                            ngay_340 += 1;
                        }
                        break;
                    case 2:
                        ngayTruoc_340 = ngay_340;
                        if (ngayTruoc_340 == 1)
                        {
                            ngayTruoc_340 = 31;
                            thangTruoc_340 = thang_340 - 1;
                            namTruoc_340 = nam_340;
                        }
                        else
                        {
                            ngayTruoc_340 = ngay_340 - 1;
                            thangTruoc_340 = thang_340;
                            namTruoc_340 = nam_340;
                        }
                        Console.WriteLine("ngay truoc do la: {0}-{1}-{2}", ngayTruoc_340, thangTruoc_340, namTruoc_340);
                        if (nam_340 % 4 == 0)
                        {
                            if(ngay_340 == 29)
                            {
                                ngay_340 = 1;
                                thang_340 += 1;
                            }
                            else
                            {
                                ngay_340 += 1;
                            }
                        }
                        else
                        {
                            if(ngay_340 == 28)
                            {
                                ngay_340 = 1;
                                thang_340 += 1;
                            }
                            else
                            {
                                ngay_340 += 1;
                            }
                        }
                        break;
                }
                Console.WriteLine("ngay tiep theo la: {0}-{1}-{2}",ngay_340,thang_340,nam_340);
            }
        }
    }
}
