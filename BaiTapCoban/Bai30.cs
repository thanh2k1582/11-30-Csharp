using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai30
    {
        public class BT30
        {
            public void laiXuat()
            {
                double laiXuat_340, tienVon_340, thoiHan_340, a_340;
                Console.WriteLine("Nhap lai xuat , tien von va thoi han: \nLai xuat:");
                laiXuat_340 = double.Parse(Console.ReadLine());
                Console.WriteLine("Tien von: ");
                tienVon_340 = double.Parse(Console.ReadLine());
                Console.WriteLine("Thoi han: ");
                thoiHan_340 = double.Parse(Console.ReadLine());
                Console.WriteLine("  Nam               Von");
                for(int i = 1; i <= thoiHan_340; i++)
                {
                    a_340 = tienVon_340 * Math.Pow((1+ laiXuat_340),i);
                    Console.Write("   {0}", i);
                    Console.WriteLine("              {0}", String.Format("{0:0.0}", a_340));
                }
            }
        }
    }
}
