using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai11
    {
        public class BT11
        {
            public void KBB()
            {
                string kbb_340,value_340;
                int human_340 = 0, a_340 = 0, b_340 = 0;
                int computor_340 = 0;
                Random x_340 = new Random();
                Console.WriteLine("{0}", x_340.Next(0, 3));
                string[] tuti_340 = {"keo","bua","bao"};
                Console.WriteLine("{0}",tuti_340[x_340.Next(0, 3)]);
                do
                {
                    Console.WriteLine("Nhap keo-bua-bao de choi tro choi , nhap ky tu khac de thoat: ");
                    kbb_340 = Console.ReadLine();
                    switch (kbb_340)
                    {
                        case "keo":
                            value_340 = tuti_340[x_340.Next(0, 3)];
                            Console.WriteLine("{0}", value_340);
                            switch (value_340)
                            {
                                case "keo":
                                    a_340 = a_340;
                                    b_340 = b_340;
                                    break;
                                case "bua":
                                    a_340 = a_340;
                                    b_340 += 1;
                                    break;
                                case "bao":
                                    a_340 += 1;
                                    b_340 = b_340;
                                    break;
                            }
                            Console.WriteLine("humua - computer: {0}-{1}", a_340, b_340);
                            break;
                        case "bua":
                            value_340 = tuti_340[x_340.Next(0, 3)];
                            Console.WriteLine("{0}", value_340);
                            switch (value_340)
                            {
                                case "keo":
                                    a_340 += 1;
                                    b_340 = b_340;
                                    break;
                                case "bua":
                                    a_340 = a_340;
                                    b_340 = b_340;
                                    break;
                                case "bao":
                                    a_340 = a_340;
                                    b_340 += 1;
                                    break;
                            }
                            Console.WriteLine("humua - computer: {0}-{1}", a_340, b_340);
                            break;
                        case "bao":
                            value_340 = tuti_340[x_340.Next(0, 3)];
                            Console.WriteLine("{0}", value_340);
                            switch (value_340)
                            {
                                case "keo":
                                    a_340 = a_340;
                                    b_340 += 1;
                                    break;
                                case "bua":
                                    a_340 += 1;
                                    b_340 = b_340;
                                    break;
                                case "bao":
                                    a_340 = a_340;
                                    b_340 = b_340;
                                    break;
                            }
                            Console.WriteLine("humua - computer: {0}-{1}", a_340, b_340);
                            break;
                        default: break;
                    };
                }
                while (kbb_340 == "keo" || kbb_340 == "bua" || kbb_340 == "bao");
            }
        }
    }
}
