using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai9
    {
        public class BT9
        {
            public void vTron()
            {
                int x;
                Console.WriteLine("Nhap so do x cua goc (phut) : ");
                x = int.Parse(Console.ReadLine());
                float y = (float)(x / 60);
                float z = y;
                Console.WriteLine("x: {0}", y);
                float radian = (float)(y*Math.PI/180);
                float cos = (float)(Math.Cos(radian));
                do
                {
                    while (y > 360)
                    {
                        y -= 360;
                    }
                }
                while (y > 360);
                if (y <= 90)
                {
                    Console.WriteLine("x thuoc goc vuong thu 1 ");
                }
                if(y > 90 && y <= 180)
                {
                    Console.WriteLine("x thuoc goc vuong thu 2");
                }
                if(y > 180 && y <= 270)
                {
                    Console.WriteLine("x thuoc goc vuong thu 3 ");
                }
                if (y > 270)
                {
                    Console.WriteLine("x thuoc goc vuong thu 4 ");
                }
                Console.WriteLine("Cos({0}): {1}", z, cos);
            } 
        }
    }
}
