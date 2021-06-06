using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/// <summary>
/// 1ИСП11-17 Маханов А.А.
/// </summary>

namespace ConsoleApp2
{
    class Program
    {
        static public void prog1()
        {
            //listing
        }
        static public void prog2()
        {
            //программа 2
            Console.WriteLine("Напишите число");
            int x = Int32.Parse(Console.ReadLine());
            if (x / 3 == 0)
            {
                if (x / 7 == 0)
                {
                    MessageBox.Show("Делится и на 3 и на 7");
                }
                else
                {
                    MessageBox.Show("Делится на 3, но не на 7");
                }
            }
            else
            {
                if (x / 7 == 0)
                {
                    MessageBox.Show("Делится на 7, но не на 3");
                }
                else
                {
                    MessageBox.Show("Не делится ни на 3 ни на 7");
                }
            }
        }
        static public void prog3()
        {
            //программа 3
            Console.WriteLine("Напишите число 1");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Напишите число 2");
            int y = Int32.Parse(Console.ReadLine());
            if (x > y) 
            {
                MessageBox.Show("Число 1 больше числа 2");
            }
            else if (x == 7)
            {
                MessageBox.Show("Числа равны");
            }
            else
            {
                MessageBox.Show("Число 2 больше числа 1");
            }
        }
        static public void prog4()
        {
            //программа 4
            int x = 0;
            int y = 0;
            while (true)
            {
                Console.WriteLine("Напишите число");
                y = Int32.Parse(Console.ReadLine());
                if (y == 0)
                {
                    break;
                }
                x += y;
            }
            Console.WriteLine();
        }
        static public void prog5()
        {
            //программа 5
            Console.WriteLine("Напишите день недели (маленькими буквами)");
            string day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("понедельник");
                    break;
                case "2":
                    Console.WriteLine("вторник");
                    break;
                case "3":
                    Console.WriteLine("среда");
                    break;
                case "4":
                    Console.WriteLine("четверг");
                    break;
                case "5":
                    Console.WriteLine("пятница");
                    break;
                case "6":
                    Console.WriteLine("суббота");
                    break;
                case "7":
                    Console.WriteLine("воскресенье");
                    break;
                default:
                    Console.WriteLine("Такого дня недели нет");
                    break;
            }
        }
        static public void prog6()
        {
            //программа 6
            Console.WriteLine("Напишите день недели (маленькими буквами)");
            string day = Console.ReadLine();
            switch (day)
            {
                case "понедельник":
                    Console.WriteLine("1");
                    break;
                case "вторник":
                    Console.WriteLine("2");
                    break;
                case "среда":
                    Console.WriteLine("3");
                    break;
                case "четверг":
                    Console.WriteLine("4");
                    break;
                case "пятница":
                    Console.WriteLine("5");
                    break;
                case "суббота":
                    Console.WriteLine("6");
                    break;
                case "воскресенье":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Такого дня недели нет");
                    break;
            }
        }
        static public void prog7()
        {
            //программа 7
            int i = 0;
            int sum = 0;
            Console.WriteLine("Напишите число четных чисел");
            int n = Int32.Parse(Console.ReadLine());
            //for (i = 0; i <= n; i++)
            //{
            //    sum += i * 2;
            //}
            while (i <= n)
            {
                sum += i * 2;
                i++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(n * (n + 1));
        }
        static public void prog8()
        {
            //программа 8
            int i = 0;
            int sum = 0;
            Console.WriteLine("Напишите число натуральных чисел");
            int n = Int32.Parse(Console.ReadLine());
            //for (i = 0; i <= n; i++)
            //{
            //    sum += i * i;
            //}
            while (i <= n)
            {
                sum += i * i;
                i++;
            }
            Console.WriteLine(sum);
            Console.WriteLine(n * (n + 1) * (n + 2) / 6);
        }
        static public void prog9()
        {
            //программа 9
            int i = 1;
            int x = 0;
            int y = 1;
            Console.WriteLine("Напишите число натуральных чисел");
            int n = Int32.Parse(Console.ReadLine());
            //for (i = 0; i <= n; i++)
            //{
            //  int tempx = y;
            //  int tempy = x + y;
            //  Console.WriteLine(tempx);
            //  x = tempx;
            //  y = tempy;
            //}
            while (i <= n)
            {
                int tempx = y;
                int tempy = x + y;
                Console.WriteLine(tempx);
                x = tempx;
                y = tempy;
                i++;
            }
        }
        static public void prog10()
        {
            //программа 10
            Console.WriteLine("Напишите 2 числа");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int a = x;
            int b = y;
            if (x > y)
            {
                b = x;
                a = y;
            }
            //for (int i = a; i <= b; i++)
            //{
            //    Console.WriteLine(i);
            //}
            int i = a;
            while (i <= b)
            {
                Console.WriteLine(i);
            }
        }
        static public void prog11()
        {
            //программа 11
            int i = 0;
            int x = 1;
            int sum = 0;
            Console.WriteLine("Напишите число чисел");
            int n = Int32.Parse(Console.ReadLine());
            //for (i = 0; i <= n; i++)
            //{
            //    int y = 0;
            //    while (y / 3 != 1)
            //    {
            //        y = x * 5 + 2;
            //        x++;
            //    }
            //    sum += y;
            //}
            while (i <= n)
            {
                int y = x * 5 + 2;
                x++;
                if (y / 3 == 1)
                {
                    sum += y;
                    i++;
                }
            }
        }
        static void Main(string[] args)
        {
            string num = Interaction.InputBox("Какую программу открыть?", "Программа");
            //выбор программы 1-11
            switch (num)
            {
                case "1":
                    prog1();
                    break;
                case "2":
                    prog2();
                    break;
                case "3":
                    prog3();
                    break;
                case "4":
                    prog4();
                    break;
                case "5":
                    prog5();
                    break;
                case "6":
                    prog6();
                    break;
                case "7":
                    prog7();
                    break;
                case "8":
                    prog8();
                    break;
                case "9":
                    prog9();
                    break;
                case "10":
                    prog10();
                    break;
                case "11":
                    prog11();
                    break;
                default:
                    MessageBox.Show("Неверный номер");
                    break;
            }
            Console.ReadLine();
        }
    }
}