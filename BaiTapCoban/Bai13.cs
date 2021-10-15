using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai13
    {
        public class BT13
        {
            public void ngayThang()
            {
                int ngay_340, thang_340, nam_340;
                Console.Write("Ngay: ");
                ngay_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Thang: ");
                thang_340 = Int32.Parse(Console.ReadLine());
                Console.Write("Nam: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                float dayofweek_340 = (float)(ngay_340 + ((13*(thang_340 + 1))/5)+ nam_340 % 100+(nam_340 % 100)/4+5- nam_340 / 100) % 7;
                switch (dayofweek_340) {
                    case 1: Console.WriteLine("Thu 2");
                        break;
                    case 2:
                        Console.WriteLine("Thu 3");
                        break;
                    case 3:
                        Console.WriteLine("Thu 4");
                        break;
                    case 4:
                        Console.WriteLine("Thu 5");
                        break;
                    case 5:
                        Console.WriteLine("Thu 6");
                        break;
                    case 6:
                        Console.WriteLine("Thu 7");
                        break;
                    case 0:
                        Console.WriteLine("Chu nhat");
                        break;
                };
            }
        }
    }
}
