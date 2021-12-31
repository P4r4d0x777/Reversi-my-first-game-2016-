using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговая_Реверси_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[8, 8];
            bool xod = false;
            POLE(mas);
            SCHET(mas);
            XOD(ref xod);
            PODZKAZKA(mas, ref xod);
            PERERISOVKA(mas);
            KOLVO(mas);
            IGRA(mas, ref xod);
        }
        static void KOLVO(int[,] mas)
        {
            int ch = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 3)
                        ch++;
                }
            Console.SetCursorPosition(10, 11);
            Console.Write("Возможное количество ходов = " + ch);
        }
        static void SCHET(int[,] mas)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(0, 11);
            int schet1 = 0, schet2 = 0;
            Console.WriteLine("СЧЕТ");
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 1)
                        schet1++;
                    if (mas[i, j] == 2)
                        schet2++;
                }
            Console.WriteLine(schet1 < 10 ? ("\nБелыe:" + "0" + schet1) : ("\nБелыe:" + schet1));
            Console.WriteLine(schet2 < 10 ? ("Черные:" + "0" + schet2) : ("Черные:" + schet2));
        }
        static void POLE(int[,] mas)
        {
            Console.WriteLine("╦ ╦┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐ ┌┬┐┌─┐ ┌┬┐┬ ┬┌─┐ ┌─┐┌─┐┌┬┐┌─┐");
            Console.WriteLine("║║║├┤ │  │  │ ││││├┤   │ │ │  │ ├─┤├┤  │ ┬├─┤│││├┤");
            Console.WriteLine("╚╩╝└─┘┴─┘└─┘└─┘┴ ┴└─┘  ┴ └─┘  ┴ ┴ ┴└─┘ └─┘┴ ┴┴ ┴└─┘");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╦═╗┌─┐┬  ┬┌─┐┬─┐┌─┐┬");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╠╦╝├┤ └┐┌┘├┤ ├┬┘└─┐│");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╩╚═└─┘ └┘ └─┘┴└─└─┘┴");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n invented by Igor X\n 2016");
            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            for (int i = 0; i <= mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (i == mas.GetLength(0))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" ABCDEFGH");
                        break;
                    }
                    if (j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(i + 1);
                    }
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (i == 3 && j == 3)
                    {
                        mas[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        mas[i, j + 1] = 2;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        j++;
                        continue;
                    }
                    if (i == 4 && j == 3)
                    {
                        mas[i, j + 1] = 1;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        mas[i, j] = 2;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        j++;
                        continue;
                    }
                    Console.Write(Char.ConvertFromUtf32(9830));
                }
                Console.WriteLine();
            }
        }
        static void PERERISOVKA(int[,] mas)
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (i == mas.GetLength(0))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(" ABCDEFGH");
                        break;
                    }
                    if (j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(i + 1);
                    }
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (mas[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        continue;
                    }
                    if (mas[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        continue;
                    }
                    if (mas[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(Char.ConvertFromUtf32(9830));
                        continue;
                    }
                    Console.Write(Char.ConvertFromUtf32(9830));
                }
                Console.WriteLine();
            }
        }
        static void XOD(ref bool xod)
        {
            Console.SetCursorPosition(10, 12);
            if (xod == true)
                Console.WriteLine("Ходят белые!");
            if (xod == false)
                Console.WriteLine("Ходят черные!");
        }
        static void PODZKAZKA(int[,] mas, ref bool xod)
        {
            int c = 0;
            int b = 0;
            for (int i1 = 0; i1 < mas.GetLength(0); i1++)
                for (int j1 = 0; j1 < mas.GetLength(1); j1++)
                {
                    if (mas[i1, j1] == 3)
                        mas[i1, j1] = 0;
                }
            for (int i = 1; i <= mas.GetLength(0); i++)
                for (int j = 1; j <= mas.GetLength(1); j++)
                {
                    if (mas[i - 1, j - 1] == 2 & xod == false)
                    {
                        b = 0;
                        c = 2;
                        PROVERKA(mas, i - 1, j - 1, ref xod, c, b);
                    }
                    if (mas[i - 1, j - 1] == 1 & xod == true)
                    {
                        c = 1;
                        b = 2;
                        PROVERKA(mas, i - 1, j - 1, ref xod, c, b);
                    }
                }
        }
        static void PROVERKA(int[,] mas, int x, int y, ref bool xod, int c, int b)
        {
            for (int i = 1; i <= mas.GetLength(0); i++)
                for (int j = 1; j <= mas.GetLength(1); j++)
                {
                    if (mas[i - 1, j - 1] == c)
                    {
                        if (j - 1 == y)
                        {
                            //вверх
                            for (int i1 = i - 1; i1 > 1; i1--)
                            {
                                if (mas[i1 - 1, y] == c - 1 + b)
                                {
                                    if (mas[i1 - 2, y] == 1 || mas[i1 - 2, y] == 2)
                                        continue;
                                    mas[i1 - 2, y] = 3;
                                }
                                else
                                    break;
                            }
                            //вниз
                            for (int i1 = i - 1; i1 < 6; i1++)
                            {
                                if (mas[i1 + 1, y] == c - 1 + b)
                                {
                                    if (mas[i1 + 2, y] == 1 || mas[i1 + 2, y] == 2)
                                        continue;
                                    mas[i1 + 2, y] = 3;
                                }
                                else
                                    break;
                            }
                        }
                        if (i - 1 == x)
                        {
                            //вправо
                            for (int i1 = j - 1; i1 < 6; i1++)
                            {
                                if (mas[x, i1 + 1] == c - 1 + b)
                                {
                                    if (mas[x, i1 + 2] == 1 || mas[x, i1 + 2] == 2)
                                        continue;
                                    mas[x, i1 + 2] = 3;
                                }
                                else
                                    break;
                            }
                            //влево
                            for (int i1 = j - 1; i1 > 1; i1--)
                            {
                                if (mas[x, i1 - 1] == c - 1 + b)
                                {
                                    if (mas[x, i1 - 2] == 1 || mas[x, i1 - 2] == 2)
                                        continue;
                                    mas[x, i1 - 2] = 3;
                                }
                                else
                                    break;
                            }
                        }
                        //вправо вверх
                        for (int i1 = x, j1 = y; i1 >= 2 & j1 < 6; i1--, j1++)
                        {
                            if (mas[i1 - 1, j1 + 1] == c - 1 + b)
                            {
                                if (mas[i1 - 2, j1 + 2] == 1 || mas[i1 - 2, j1 + 2] == 2)
                                    continue;
                                mas[i1 - 2, j1 + 2] = 3;
                            }
                            else
                                break;
                        }
                        //вправо вниз
                        for (int i1 = x, j1 = y; i1 < 6 & j1 < 6; i1++, j1++)
                        {
                            if (mas[i1 + 1, j1 + 1] == c - 1 + b)
                            {
                                if (mas[i1 + 2, j1 + 2] == 1 || mas[i1 + 2, j1 + 2] == 2)
                                    continue;
                                mas[i1 + 2, j1 + 2] = 3;
                            }
                            else
                                break;
                        }
                        //влево вверх
                        for (int i1 = x, j1 = y; i1 >= 2 & j1 >= 2; i1--, j1--)
                        {
                            if (mas[i1 - 1, j1 - 1] == c - 1 + b)
                            {
                                if (mas[i1 - 2, j1 - 2] == 1 || mas[i1 - 2, j1 - 2] == 2)
                                    continue;
                                mas[i1 - 2, j1 - 2] = 3;
                            }
                            else
                                break;
                        }
                        //влево вниз
                        for (int i1 = x, j1 = y; i1 < 6 & j1 >= 2; i1++, j1--)
                        {
                            if (mas[i1 + 1, j1 - 1] == c - 1 + b)
                            {
                                if (mas[i1 + 2, j1 - 2] == 1 || mas[i1 + 2, j1 - 2] == 2)
                                    continue;
                                mas[i1 + 2, j1 - 2] = 3;
                            }
                            else
                                break;
                        }
                    }
                }
        }
        static void IGRA(int[,] mas, ref bool xod)
        {
            int end = 1, ch1 = 1;
            int x1 = 0, y1 = 0;
            int k;
            bool s;
            Console.SetCursorPosition(0, 15);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Введите 0 для выхода");
            string MENU;
            do
            {
                Console.SetCursorPosition(0, 15 + ch1);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ХОД:");
                Console.ResetColor();
                MENU = Console.ReadLine();
                s = true;
                if (char.IsNumber(MENU[0]))
                {
                    x1 = int.Parse(MENU[0].ToString());
                    if (x1 == 0)
                        break;
                }
                else
                {
                    ch1 += 2;
                    Console.WriteLine("Неверная координата");
                    continue;
                }
                string S = MENU.Remove(0, 1);
                switch (S)
                {
                    case "A":
                    y1 = 1;
                    break;
                    case "B":
                    y1 = 2;
                    break;
                    case "C":
                    y1 = 3;
                    break;
                    case "D":
                    y1 = 4;
                    break;
                    case
                "E":
                    y1 = 5;
                    break;
                    case "F":
                    y1 = 6;
                    break;
                    case "G":
                    y1 = 7;
                    break;
                    case "H":
                    y1 = 8;
                    break;
                    default:
                        {
                            ch1 += 2;
                            s = false;
                            Console.WriteLine("Неверная координата");
                            break;
                        }
                }
                if (s == false)
                    continue;
                if (mas[x1 - 1, y1 - 1] != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ход в данную клетку не возможен");
                    ch1 += 2;
                    continue;
                }
                ch1++;
                TRI(mas, x1, y1);
                if (xod == false)
                {
                    k = 2;
                    PEREVOROT(mas, ref xod, x1, y1, k);
                }
                else
                {
                    k = 1;
                    PEREVOROT(mas, ref xod, x1, y1, k);
                }
                END(mas, ref end);
                PODZKAZKA(mas, ref xod);
                PEREXOD(mas, ref xod);
                SCHET(mas);
                XOD(ref xod);
                KOLVO(mas);
                PERERISOVKA(mas);
            }
            while (end != 2);
        }
        static void TRI(int[,] mas, int x, int y)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 3)
                        mas[i, j] = 0;
                    mas[x - 1, y - 1] = 3;
                }
        }
        static void END(int[,] mas, ref int end)
        {
            int ch = 0, chern = 0, belii = 0;
            for (int i1 = 0; i1 < mas.GetLength(0); i1++)
                for (int j1 = 0; j1 < mas.GetLength(1); j1++)
                {
                    if (mas[i1, j1] == 2 || mas[i1, j1] == 1)
                        ch++;
                    if (mas[i1, j1] == 2)
                        chern++;
                    if (mas[i1, j1] == 1)
                        belii++;
                }
            if (ch == 64 || end == 2)
            {
                end = 2;
                Console.WriteLine(chern > belii ? ("\nПобедили черные") : chern < belii ? ("\nПобедили белые") : ("\nНичья"));
                Console.WriteLine("Нажмите ENTER для выхода!");
                Console.ReadKey();
            }
        }
        static void PEREVOROT(int[,] mas, ref bool xod, int x, int y, int k)
        {
            for (int i = 1; i <= mas.GetLength(0); i++)
                for (int j = 1; j <= mas.GetLength(1); j++)
                {
                    if (mas[i - 1, j - 1] == k)
                    {
                        if (i - 1 == x - 1)
                        {
                            if (y > 1)
                            {
                                for (int i1 = j - 1; i1 <= y - 1; i1++)
                                {
                                    if (mas[x - 1, y - 2] == 0 || mas[x - 1, i1] == 0)
                                        break;
                                    mas[x - 1, i1] = k;
                                }
                            }
                            if (y < 7)
                            {
                                for (int i1 = j - 1; i1 >= y - 1; i1--)
                                {
                                    if (mas[x - 1, y] == 0 || mas[x - 1, i1] == 0)
                                        break;
                                    mas[x - 1, i1] = k;
                                }
                            }
                        }
                        if (j - 1 == y - 1)
                        {
                            for (int i1 = i - 1; i1 >= x - 1; i1--)
                            {
                                if (x < 8)
                                {
                                    if ((mas[x, y - 1] == 0 || mas[i1, y - 1] == 0) & x < 8)
                                        break;
                                    mas[i1, y - 1] = k;
                                }
                            }
                            for (int i1 = i - 1; i1 <= x - 1; i1++)
                            {
                                if (x > 3)
                                {
                                    if (mas[x - 2, y - 1] == 0 || mas[i1, y - 1] == 0)
                                        break;
                                    mas[i1, y - 1] = k;
                                }
                            }
                        }
                        if ((i - 1 + j - 1) == (x - 1 + y - 1) & i - 1 > x - 1)
                        {
                            for (int i1 = i - 1, j1 = j - 1; i1 > x - 1 & j1 < y - 1; i1--, j1++)
                            {
                                if (mas[x, y - 2] == 0 || mas[i1 - 1, j1 + 1] == 0)
                                    break;
                                mas[i1 - 1, j1 + 1] = k;
                            }
                        }
                        if ((x - 1 - y - 1) == (i - 1 - j - 1) & i - 1 < x - 1)
                        {
                            for (int i1 = i - 1, j1 = j - 1; i1 < x - 1 & j1 < y - 1; i1++, j1++)
                            {
                                if (mas[x - 2, y - 2] == 0 || mas[i1 + 1, j1 + 1] == 0)
                                    break;
                                mas[i1 + 1, j1 + 1] = k;
                            }
                        }
                        if ((x - 1 - y - 1) == (i - 1 - j - 1) & i - 1 > x - 1)
                        {
                            for (int i1 = i - 1, j1 = j - 1; i1 > x - 1 & j1 > y - 1; i1--, j1--)
                            {
                                if (mas[x, y] == 0 || mas[i1 - 1, j1 - 1] == 0)
                                    break;
                                mas[i1 - 1, j1 - 1] = k;
                            }
                        }
                        if ((i - 1 + j - 1) == (x - 1 + y - 1) & i - 1 < x - 1)
                        {
                            for (int i1 = i - 1, j1 = j - 1; i1 < x - 1 & j1 > y - 1; i1++, j1--)
                            {
                                if (mas[x - 2, y] == 0 || mas[i1 + 1, j1 - 1] == 0)
                                    break;
                                mas[i1 + 1, j1 - 1] = k;
                            }
                        }
                    }
                }
            xod = (xod == false) ? true : false;
        }
        static void PEREXOD(int[,] mas, ref bool xod)
        {
            int ch = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] == 3)
                        ch++;
                }
            int end = 0;
            if (ch == 0 & xod == true)
            {
                end++;
                Console.WriteLine("\nБелые не могут ходить! Переход хода.");
                xod = false;
                PODZKAZKA(mas, ref xod);
            }
            if (ch == 0 & xod == false)
            {
                end++;
                Console.WriteLine("\nЧерные не могут ходить! Переход хода.");
                xod = true;
                PODZKAZKA(mas, ref xod);
            }
            if (end == 2)
            {
                END(mas, ref end);
            }
        }
    }
}