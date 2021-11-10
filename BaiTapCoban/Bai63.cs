using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai63
    {
        public class BT63
        {
            public void _63()
            {
                int Numrd, a=0;
                Random rd = new Random();
                int n;
                Console.WriteLine("Nhap so phan tu mang: ");
                n = Int32.Parse(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    array[i] = rd.Next(-100, 100);
                }
                //Xuat gia tri da nhap
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                    if (array[i] % 4==0 && array[i] % 10 ==6)
                    {
                        a += 1;
                    }
                }
                Console.WriteLine("");
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    
                    if (i % 2 == 1)
                    {
                        array[i] *= 2;
                    }
                    Console.Write("{0}   ", array[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("co {0} phan tu chia het cho 4, tan cung la 6",a);
               
            }
        }
        }
}
