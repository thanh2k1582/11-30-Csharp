using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai40
    {
        public class BT40
        {
            public void btCo()
            {
                int a=0, b=0, c=0;
                for(int i = 1; i <= 20;i++)
                {
                    a = i;
                    for (int j = 1; j <= 34; j++) {
                        b = j;
                        for (int z = 1; z <=100;z++)
                        {
                            c = z;
                            if((a * 5 + b * 3 + c / 3) == 100 && c % 3 ==0 && a + b +c == 100)
                            {
                                Console.WriteLine("{0} trau dung ,{1} trau nam ,{2} trau gia",a,b,c);break;
                            }
                        }
                    }
                }
            }
        }
    }
}
