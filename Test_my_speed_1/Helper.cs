using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_speed_1
{
    class Helper
    {
        public delegate void SimpleFunction();

        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="str">
        /// Строка, выводимая в консоль.
        /// </param>
        public static void Print(string str) => Console.WriteLine(str);

        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="x">
        /// Целое число, выводимое в консоль.
        /// </param>
        public static void Print(int x) => Console.WriteLine(x);

        /// <summary>
        /// Функция для упращения вывода данных в консоль.
        /// </summary>
        /// <param name="x">
        /// Число типа double, выводимое в консоль.
        /// </param>
        public static void Print(double x) => Console.WriteLine(x);

        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="welcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static int IntInput(string welcome)
        {
            int n = 0;
            Print(welcome);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Print("Error. " + welcome);
            }
            return n;
        }


        public static int IntInput(string welcome, int minValue, int maxValue)
        {
            int n = 0;
            Print(welcome);
            while (!int.TryParse(Console.ReadLine(), out n) || n > maxValue || n < minValue)
            {
                Print("Error. " + welcome);
            }
            return n;
        }


        public static int IntInput(string welcome, int minValue, int maxValue, SimpleFunction function)
        {
            int n = 0;
            Print(welcome);
            function();
            while (!int.TryParse(Console.ReadLine(), out n) || n > maxValue || n < minValue)
            {
                Console.Clear();
                Print("Error. " + welcome);
                function();
            }
            return n;
        }

        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="welcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static uint UintInput(string welcome)
        {
            uint n = 0;
            Print(welcome);
            while (!uint.TryParse(Console.ReadLine(), out n))
            {
                Console.Clear();
                Print(welcome);
            }
            return n;
        }
        /// <summary>
        /// Функция, реализующая циклический ввод числа
        /// </summary>
        /// <param name="welcome"></param>
        /// <returns>
        /// Введенное число
        /// </returns>
        public static double DoubleInput(string welcome)
        {
            double n = 0;
            Print(welcome);
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Print("Error. " + welcome);
            }
            return n;
        }
    }
}
