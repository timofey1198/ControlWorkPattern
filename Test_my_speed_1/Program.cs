// Дисциплина: Программирование
// Группа: 173ПИ/2
// Студент: Стародубцев Тимофей
// Задача: Вариант...
// Дата: 21.09.2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_my_speed_1
{
    class Program : Helper
    {
        public static void PrintColors()
        {
            for (int i = 0; i <= 15; i++)
            {
                if (i == 15)
                {
                    Print(i.ToString() + " - Random :)");
                }
                else
                {
                    ConsoleColor color = (ConsoleColor)i;
                    Print(i.ToString() + " - " + color.ToString());
                }
            }
        }

        static MyRandom rnd = new MyRandom();
        static void Main(string[] args)
        {
            // Цикл повторной работы программы
            do
            {
                int i;
                Console.Clear();

                int colorIndex = IntInput("Выберете цвет:", 0, 15, PrintColors);
                ConsoleColor consoleColor;
                if (colorIndex == 15)
                {
                    colorIndex = rnd.Next(0, 14, MyRandom.Boundary.include, MyRandom.Boundary.include);
                }
                consoleColor = (ConsoleColor)colorIndex;
                Console.ForegroundColor = consoleColor;
                // Основной код программы
                //uint x = UintInput("Введите x:");
                
                for (i = 0; i < 10; i++)
                {
                    double a = rnd.NextDouble(0, 11, MyRandom.Boundary.include, MyRandom.Boundary.include);
                    Print(a);
                    if (a > 10 || a < 0)
                    {
                        Print("!!!");
                    }
                }
                //this.kuku = Console.Write;


                // Выход из цикла повторной работы
                Print("Для продолжения нажмите любую клавишу. Для выхода нажмите Escape.");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}