using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai62
    {
        public class BT62
        {
            public void _62()
            {
                int Numrd, s1 = 0,s2=0, a,c=0,d=0,e=0;
                Random rd = new Random();
                int n;
                Console.WriteLine("Nhap so phan tu mang: ");
                n = Int32.Parse(Console.ReadLine());
                int[] array = new int[n];
                int[] arrayCon = new int[100];
                int[] arrayConn = new int[100];
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    array[i] = rd.Next(10,20);
                }
                //Xuat gia tri da nhap
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                    if(i%2==0 && array[i] %2 == 0)
                    {
                        s1 += array[i];
                    }
                    if (i % 2 == 1 && array[i] % 2 == 1)
                    {
                        s2 += array[i];
                    }
                    for(int j= 1; j <= i; j++)
                    {

                    }
                }
                if( s1 == s2)
                {
                    Console.WriteLine("\nTong so le o vi tri chan {0} bang tong so chan o vi tri le {1} ",s2,s1);
                }
                else
                {
                    Console.WriteLine("\nTong so le o vi tri chan {0} khac tong so chan o vi tri le {1} ", s2, s1);
                }

            }
        }
    }
}
