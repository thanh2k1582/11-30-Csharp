using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai16
    {
        public class BT16
        {
            public void inlich()
            {
                int nam_340,n=1;
                Console.WriteLine("Nhap nam can in lich: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                for(int i_340=1; i_340 <= 12; i_340++)
                {
                    if( i_340 == 1 || i_340==3 || i_340==5 || i_340==7 || i_340==8 || i_340==10 || i_340==12)
                    {
                        Console.WriteLine("Thang {0}:", i_340);
                        Console.WriteLine("  S  M  T  W  T  F  S  ");
                        for(int j_340 = 1; j_340 <= 31; j_340++)
                        {
                            float dayofweek_340 = (float)(j_340 + ((13 * (i_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if(j_340 == 1)
                                    {
                                        Console.Write("     {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("        {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("           {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("              {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                 {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                    {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("  {0}", j_340); }
                                        else { Console.WriteLine(" {0}", j_340); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("  {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                            };
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                    }
                    if (i_340 == 4 || i_340==6 || i_340== 9 || i_340==11)
                    {
                        Console.WriteLine("Thang {0}:", i_340);
                        Console.WriteLine("  S  M  T  W  T  F  S  ");
                        for (int j_340 = 1; j_340 <= 30; j_340++)
                        {
                            float dayofweek = (float)(j_340 + ((13 * (i_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("        {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("           {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("              {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                 {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                    {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("  {0}", j_340); }
                                        else { Console.WriteLine(" {0}", j_340); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("  {0}", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                        else { Console.Write(" {0}", j_340); }
                                    }
                                    break;
                            };
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                    }
                    if (i_340 == 2)
                    {
                        Console.WriteLine("Thang {0}:", i_340);
                        Console.WriteLine("  S  M  T  W  T  F  S  ");
                        if (nam_340 % 4 == 0)
                        {
                            for (int j_340 = 1; j_340 <= 29; j_340++)
                            {
                                float dayofweek = (float)(j_340 + ((13 * (i_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                                switch (dayofweek)
                                {
                                    case 1:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("     {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 2:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("        {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 3:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("           {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 4:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("              {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 5:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("                 {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 6:
                                        if (j_340 == 1)
                                        {
                                            Console.WriteLine("                    {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.WriteLine("  {0}", j_340); }
                                            else { Console.WriteLine(" {0}", j_340); }
                                        }
                                        break;
                                    case 0:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("  {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                };
                            }
                        }
                        else
                        {
                            for (int j_340 = 1; j_340 <= 28; j_340++)
                            {
                                float dayofweek = (float)(j_340 + ((13 * (i_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                                switch (dayofweek)
                                {
                                    case 1:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("     {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 2:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("        {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 3:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("           {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 4:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("              {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 5:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("                 {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                    case 6:
                                        if (j_340 == 1)
                                        {
                                            Console.WriteLine("                    {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.WriteLine("  {0}", j_340); }
                                            else { Console.WriteLine(" {0}", j_340); }
                                        }
                                        break;
                                    case 0:
                                        if (j_340 == 1)
                                        {
                                            Console.Write("  {0}", j_340);
                                        }
                                        else
                                        {
                                            if (j_340 < 10) { Console.Write("  {0}", j_340); }
                                            else { Console.Write(" {0}", j_340); }
                                        }
                                        break;
                                };
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }


                }
            }
        }
    }
}
