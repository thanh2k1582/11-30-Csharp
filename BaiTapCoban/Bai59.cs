using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai59
    {
        public class BT59
        {
            public void _59()
            {
                string[] can = { "canh","tan","nham","quy","giap","at","binh","dinh","mau","ky"};
                string[] chi = { "than","dau","tuat","hoi","ty","suu","dan","mao","thin","ty","ngo","mui"};
                int n,a=0,b=0;
                Console.WriteLine("Nhap nam: ");
                n = Int32.Parse(Console.ReadLine());
                a = n % 10;
                b = n % 12;
                Console.WriteLine("Day la nam {0} {1} , nam ke tiep cung ten Am lich la {2}",can[a],chi[b],n+60);
            }
        }
    }
}
