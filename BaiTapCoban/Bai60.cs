using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai60
    {
        public class BT60
        {
            public void _60()
            {

                int Numrd,b,c,d,f;
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
                for (int i = 1; i < (n-1)/2; )//Phan tu dau tien bat dau =0
                {
                    f = array[i];


                    b = array[i];
                    c = array[i + 1];
                    d = array[n / 2 + 1];
                    array[i] = d;
                    array[i + 1] = b;

                    i += 2;


                    b = array[i];
                    array[i] = array[n/2+i];
                    c = array[i + 1];
                    array[i + 1] = b;
                    i += 2;
                }
                Console.WriteLine("\nMang sau khi tron hoan hao");
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                }


            }
        }
    }
}
