using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai31
    {
        public class BT31
        {
            public void _31()
            {
                Console.WriteLine("Bang cuu chuong : ");
                for(int i = 1; i <= 10; i++)
                {
                    for(int j = 2; j <= 9; j++)
                    {
                        if (j == 9)
                        {
                            if (i < 10)
                            {
                                Console.WriteLine("{0}x {1}  = {2}     ", j, i, j * i);
                            }
                            else
                            {
                                Console.WriteLine("{0}x {1} = {2}     ", j, i, j * i);
                            }
                        }
                        else
                        {
                            if (i < 10)
                            {
                                if (j * i < 10)
                                {
                                    Console.Write("{0}x {1}  = {2}      ", j, i, j * i);
                                }
                                else
                                {
                                    Console.Write("{0}x {1}  = {2}     ", j, i, j * i);
                                }
                            }
                            else
                            {
                                if (j * i < 10)
                                {
                                    Console.Write("{0}x {1} = {2}      ", j, i, j * i);
                                }
                                else
                                {
                                    Console.Write("{0}x {1} = {2}     ", j, i, j * i);
                                }
                            }
                        }
                    }
                }
               
            }
        }
    }
}
