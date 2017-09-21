using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_speed_1
{
    class Helper
    {
        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="str">
        /// Строка, выводимая в консоль.
        /// </param>
        public static void Print(string str)
        {
            Console.WriteLine(str);
        }
        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="x">
        /// Целое число, выводимое в консоль.
        /// </param>
        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="x">
        /// Число типа double, выводимое в консоль.
        /// </param>
        public static void Print(double x)
        {
            Console.WriteLine(x);
        }
        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="wellcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static int IntInput(string wellcome)
        {
            int n = 0;
            Print(wellcome);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Print("Error. " + wellcome);
            }
            return n;
        }
        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="wellcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static uint UintInput(string wellcome)
        {
            uint n = 0;
            Print(wellcome);
            while (!uint.TryParse(Console.ReadLine(), out n))
            {
                Print("Error. " + wellcome);
            }
            return n;
        }
        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="wellcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static double DoubleInput(string wellcome)
        {
            double n = 0;
            Print(wellcome);
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Print("Error. " + wellcome);
            }
            return n;
        }
    }
}
