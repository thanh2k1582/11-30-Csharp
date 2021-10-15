using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai1
    {
        public class BT1
        {
            public void vHinhCau()
            {
                Console.WriteLine("Nhap dien tich hinh cau: ");
                float s;
                s = float.Parse(Console.ReadLine());
                float r = (float)Math.Sqrt((s / (4 * Math.PI)));
                float v = (float)(r*r*r*4/3*Math.PI);
                Console.WriteLine("the tich cua hinh cau do la:  {0}", v);

            }
        }
    }
}
