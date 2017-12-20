using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_speed_1
{
    class Helper
    {
        public static MyRandom random = new MyRandom();

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
            Console.Writeline(welcome);
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Writeline("Error. " + welcome);
            }
            return n;
        }


        public static int IntInput(string welcome, int minValue, int maxValue)
        {
            int n = 0;
            Console.Writeline(welcome);
            while (!int.TryParse(Console.ReadLine(), out n) || n > maxValue || n < minValue)
            {
                Console.Writeline("Error. " + welcome);
            }
            return n;
        }
    }
}
