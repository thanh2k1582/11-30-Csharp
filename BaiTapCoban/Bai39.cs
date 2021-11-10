using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai39
    {
        public class BT39
        {
            public void _39()
            {
                
                for(int i = 1; i < 100; i++)
                {
                    if ( i*i+(i+1)*(i+1) == (i+2)*(i+2) )
                    {
                        Console.WriteLine("{0} - {1} - {2} ba so nguyen lien tiep thoa man cong thuc công thuc Pithagoras6 ",i,i+1,i+2);
                    }
                    if ( (i * i + (i + 2) * (i + 2) == (i + 4) * (i + 4) && i % 2 == 0))
                    {
                        Console.WriteLine("{0} - {1} - {2} ba so nguyen chan lien tiep thoa man cong thuc công thuc Pithagoras6 ", i, i + 2, i + 4);

                    }
                }
            }
        }
    }
}
