using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai21
    {
        public class BT21
        {
            public void ketqua()
            {
                float diemChuan_340,mon1_340,mon2_340,mon3_340;
                Console.Write("Nhap diem chuan: ");
                diemChuan_340 = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem mon thu nhat: ");
                mon1_340 = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem mon thu nhat: ");
                mon2_340 = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem mon thu nhat: ");
                mon3_340 = float.Parse(Console.ReadLine());
                float diemTong_340 = mon1_340 + mon2_340 + mon3_340;
                string khuVuc_340;
                Console.WriteLine("Nhap khu vuc uu tien A-B-C-X");
                khuVuc_340 = Console.ReadLine();
                switch (khuVuc_340)
                {
                    case "A":
                        diemTong_340 += 2;
                        break;
                    case "B":
                        diemTong_340 += 1;
                        break;
                    case "C":
                        diemTong_340 +=(float)0.5;
                        break;
                    case "X":
                        diemTong_340 += 0;
                        break;
                }
                int doiTuong_340;
                Console.WriteLine("Nhap doi tuong uu tien 1-2-3-0");
                doiTuong_340 = Int32.Parse(Console.ReadLine());
                switch (doiTuong_340)
                {
                    case 1:
                        diemTong_340 += (float)2.5;
                        break;
                    case 2:
                        diemTong_340 += (float)1.5;
                        break;
                    case 3:
                        diemTong_340 += (float)1;
                        break;
                    case 0:
                        diemTong_340 += 0;
                        break;
                }
                if (diemTong_340 >= diemChuan_340)
                {
                    Console.WriteLine("Dau [{0}] diem",diemTong_340);
                }
                else
                {
                    Console.WriteLine("Rot [{0}] diem",diemTong_340);
                }

            }
        }
    }
}
