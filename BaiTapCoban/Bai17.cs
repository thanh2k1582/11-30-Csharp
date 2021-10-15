using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapCoban
{
    class Bai17
    {
        public class BT17
        {
            public void taoLichTruc()
            {
                int nam_340, n_340 = 1, ngayNam_340, thang_340;
                string[] phanLich_340 = { "E", "A", "B", "C", "D" };
                Console.WriteLine("Nhap nam can in lich: ");
                nam_340 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Nhap thang can in lich: ");
                thang_340 = Int32.Parse(Console.ReadLine());

                if (nam_340 % 4 == 0)
                {
                    Console.WriteLine("Thang {0}:", thang_340);
                    Console.WriteLine("     SUN      MON      TUE      WEN      THU      FRI      SAT");
                    ngayNam_340 = 366;
                    if (thang_340 == 1)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 1; ngayThang1 <= 31; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 2)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 32; ngayThang1 <= 60; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 3)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 61; ngayThang1 <= 91; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 4)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 92; ngayThang1 <= 121; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 5)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 122; ngayThang1 <= 152; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 6)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 153; ngayThang1 <= 182; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 7)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 183; ngayThang1 <= 213; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 8)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 214; ngayThang1 <= 244; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 9)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 245; ngayThang1 <= 274; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 10)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 275; ngayThang1 <= 305; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 11)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 306; ngayThang1 <= 335; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 12)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 336; ngayThang1 <= 366; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Thang {0}:", thang_340);
                    Console.WriteLine("     SUN      MON      TUE      WEN      THU      FRI      SAT");
                    if (thang_340 == 1)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 1; ngayThang1 <= 31; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 2)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 32; ngayThang1 <= 59; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 3)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 60; ngayThang1 <= 90; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 4)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 91; ngayThang1 <= 120; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 5)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 121; ngayThang1 <= 151; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 6)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 152; ngayThang1 <= 181; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 7)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 182; ngayThang1 <= 212; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 8)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 213; ngayThang1 <= 243; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 9)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 244; ngayThang1 <= 273; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 10)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 274; ngayThang1 <= 304; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 11)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 305; ngayThang1 <= 334; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                    if (thang_340 == 12)
                    {
                        int j_340 = 0;
                        for (int ngayThang1 = 335; ngayThang1 <= 365; ngayThang1++)
                        {
                            j_340++;
                            float dayofweek_340 = (float)(j_340 + ((13 * (thang_340 + 1)) / 5) + nam_340 % 100 + (nam_340 % 100) / 4 + 5 - nam_340 / 100) % 7;
                            switch (dayofweek_340)
                            {
                                case 1:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("             {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 2:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                      {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 3:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                               {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 4:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                        {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 5:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("                                                 {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.Write("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 6:
                                    if (j_340 == 1)
                                    {
                                        Console.WriteLine("                                                          {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.WriteLine("     {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                        else { Console.WriteLine("    {0}[{1}]", j_340, phanLich_340[ngayThang1 % 5]); }
                                    }
                                    break;
                                case 0:
                                    if (j_340 == 1)
                                    {
                                        Console.Write("     {0}[]", j_340);
                                    }
                                    else
                                    {
                                        if (j_340 < 10) { Console.Write("     {0}[]", j_340); }
                                        else { Console.Write("    {0}[]", j_340); }
                                    }
                                    break;
                            };
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
