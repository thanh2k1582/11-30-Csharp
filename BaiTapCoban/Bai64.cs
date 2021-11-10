using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai64
    {
        public class BT64
        {
            public void _64()
            {
                int  a = 0;
                int n,m=0,b,c,d=0;
                Console.WriteLine("Nhap so phan tu mang: ");
                n = Int32.Parse(Console.ReadLine());
                int[] array = new int[n];
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("Nhap so phan tu thu {0}: ",i);
                    array[i] = Int32.Parse(Console.ReadLine());
                }
                //Xuat gia tri da nhap
                for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                {
                    Console.Write("{0}   ", array[i]);
                    c = array[i];
                    if (c % 2 ==0) {
                        do {
                            c /= 2;
                            if (c == 1) {
                                m += 1;
                            }
                        } 
                        while (c % 2 == 0);
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Co {0} so la luy thua cua 2",m);


                Console.WriteLine("Nhap gia tri muon xoa phan tu: ");
                b = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                    {
                        d = i;
                        if (array[i] == b)
                        {
                            for (int j = i; j < n-1 ; j++)
                            {
                                array[j] = array[j + 1];
                            }
                            --n;
                            i = 0;
                    }
                }
                    for (int i = 0; i < n; i++)//Phan tu dau tien bat dau =0
                    {
                        Console.Write("{0}   ", array[i]);
                    }

            }
        }
    
}
}
