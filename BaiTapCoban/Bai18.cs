using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai18
    {
        public class BT18
        {
            public void soGio()
            {
                int tongGio_340;
                tongGio_340 = Int32.Parse(Console.ReadLine());
                int soTuan_340 = (int)(tongGio_340 / (7*24));
                int soNgay_340 = (int)((tongGio_340 % (7*24))/24);
                int soGio_340 = (int)((tongGio_340 % (7*24))%24);
                Console.WriteLine("so Tuan: {0}", soTuan_340);
                Console.WriteLine("so Ngay: {0}", soNgay_340);
                Console.WriteLine("so Gio: {0}", soGio_340);
            }
        }
    }
}
