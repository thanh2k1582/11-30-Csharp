using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai27
    {
        public class BT27
        {
            public void phanTich()
            {
                int so_340;
                Console.WriteLine("Nhap so nguyen: ");
                so_340 = Int32.Parse(Console.ReadLine());
                for (int i_340 = 1; i_340 <= so_340; i_340++) {
                    int num_340 = 0;
                    for(int j_340 = 1; j_340 <= i_340; j_340++)
                    {
                        if (i_340 % j_340 == 0)
                        {
                            num_340 += 1;
                        }
                    }
                    if(num_340 == 2 && so_340 % i_340 == 0)
                    {
                        if (i_340 == so_340)
                        {
                            Console.Write("{0}", i_340);
                        }
                        else
                        {
                            Console.Write("{0} * ", i_340);
                        }
                        so_340 /= i_340;
                        i_340 = 1;
                    }
                    
                }
                
                
            }
        }
    }
}
