using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai61
    {
        public class BT61
        {
            public void _61()
            {

                int Numrd, s=0,a,b,c;
                Random rd = new Random();
                Numrd = rd.Next(-100, 100);

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
                }
                for (int i = 0; i < n; i++)
                {
                    if (array[i] % 2 ==0 && array[i] > 0 ) {
                        s += array[i];
                    }
                }
                Console.WriteLine("\ntong cac so duong trong mang la: {0}", s);
                Console.WriteLine("Nhap thu tu phan tu muon xoa : ");
                a = Int32.Parse(Console.ReadLine());
                for (int i = a; i < n-1; i++)
                {
                    array[i] = array[i + 1];
                }
                --n;
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                }
                Console.WriteLine("\nNhap thu tu phan tu muon them : ");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gia tri phan tu : ");
                c = Int32.Parse(Console.ReadLine());
                for (int i = n; i > b; i--)
                {
                    array[i] = array[i - 1];
                }
                array[b] = c;
                ++n;
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                }

            }
        }
    }
}
