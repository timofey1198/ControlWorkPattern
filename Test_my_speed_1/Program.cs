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

namespace Test_my_speed_1
{
    class Program : Helper
    {
        static void Main(string[] args)
        {
            // Цикл повторной работы программы
            while (true)
            {
                // Основной код программы
                for (int i = 0; i < 10; i++)
                {
                    Print(i);
                }
                //
                // Выход из цикла повторной работы
                Print("Для продолжения нажмите любую клавишу. Для выхода нажмите Escape.");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}