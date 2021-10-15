using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai29
    {
        public class BT29
        {
            public void nhietDo()
            {
                float c_340 = 0, f_340 = 32,fConvert_340,cConvert_340;
                Console.WriteLine("Celcius        Fahrenheit          Fahrenheit          Celcius");
                for (c_340 = 0; c_340 <= 10; c_340++)
                {
                    fConvert_340 = 9 * c_340 / 5 + 32;
                    cConvert_340 = 5 * (f_340 - 32) / 9;

                    f_340 += 1;
                    if (c_340 < 10)
                    {
                        Console.Write("   {0}             ", c_340);

                    }
                    else
                    {
                        Console.Write("  {0}             ", c_340);
                    }
                    Console.Write("{0}                 ", String.Format("{0:0.00}", fConvert_340));
                    Console.Write("{0}                ", f_340);
                    Console.WriteLine("{0}", String.Format("{0:0.00}", cConvert_340));
                }
            }
        }
    }
}
