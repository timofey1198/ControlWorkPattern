using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_speed_1
{
    /// <summary>
    /// Дополненный класс для решения типовых задач на поиск случайных чисел
    /// </summary>
    class MyRandom: Random
    {
        ArgumentOutOfRangeException minMaxException = new ArgumentOutOfRangeException("minValue", 
            "minValue не может быть больше maxValue");

        /// <summary>
        /// Возвращает случайное целое число из промежутка
        /// </summary>
        /// <param name="minValue">
        /// Нижний предел возвращаемого случайного числа
        /// </param>
        /// <param name="maxValue">
        /// Верхний предел возвращаемого случайного числа
        /// </param>
        /// <param name="start">
        /// Тип начала отрезка
        /// </param>
        /// <param name="end">
        /// Тип конца отрезка
        /// </param>
        /// <returns>
        /// Случайное целое число
        /// </returns>
        public int Next(int minValue, int maxValue, Boundary start, Boundary end)
        {
            if (minValue > maxValue)
            {
                throw minMaxException;
            }

            if (start == Boundary.include)
            {
                if(end == Boundary.include)
                {
                    return Next(minValue, maxValue + 1);
                }
                else
                {
                    return Next(minValue, maxValue);
                }
            }
            else
            {
                if (end == Boundary.include)
                {
                    return Next(minValue - 1, maxValue + 1);
                }
                else
                {
                    return Next(minValue - 1, maxValue);
                }
            }
        }

        /// <summary>
        /// Возвращает случайное число из промежутка
        /// </summary>
        /// <param name="minValue">
        /// Нижний предел возвращаемого случайного числа
        /// </param>
        /// <param name="maxValue">
        /// Верхний предел возвращаемого случайного числа
        /// </param>
        /// <param name="start">
        /// Тип начала отрезка
        /// </param>
        /// <param name="end">
        /// Тип конца отрезка
        /// </param>
        /// <returns>
        /// Случайное число
        /// </returns>
        public double NextDouble(double minValue, double maxValue, Boundary start, Boundary end)
        {
            if (minValue > maxValue)
            {
                throw minMaxException;
            }

            double epsilon = double.Epsilon;
            double delta = maxValue - minValue;

            if (start == Boundary.include)
            {
                if (end == Boundary.include)
                {
                    return minValue + NextDouble() * (delta + epsilon);
                }
                else
                {
                    return minValue + NextDouble() * (delta);
                }
            }
            else
            {
                if (end == Boundary.include)
                {
                    return minValue + NextDouble() * (delta) + epsilon;
                }
                else
                {
                    return minValue + NextDouble() * (delta) - epsilon;
                }
            }
        }

        /// <summary>
        /// Тип концов отрезка
        /// </summary>
        public enum Boundary
        {
            include,
            omit
        }
    }
}
