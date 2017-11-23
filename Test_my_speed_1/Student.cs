using System;

namespace Test_my_speed_1
{
    public class Student : Person
    {
        ArgumentOutOfRangeException statusException = new ArgumentOutOfRangeException("Course",
            "Course должен соответствовать статусу студента (Status)");

        static MyRandom rnd = new MyRandom();

        public Student(string name, string surname, uint age)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _status = Level.bachelor;
            _course = rnd.Next(1, 5);
        }

        public Student(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _age = (uint)rnd.Next(0, 100, MyRandom.Boundary.include, MyRandom.Boundary.include);
            _status = Level.bachelor;
            _course = rnd.Next(1, 5);
        }

        public Student(string name, string surname, uint age, Level status, int course)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _status = status;
            int val = course;
            if (Status == Level.bachelor && (val < 1 || val > 4))
            {
                throw statusException;
            }
            if (Status == Level.master && (val < 1 || val > 2))
            {
                throw statusException;
            }
            if (Status == Level.specialist && (val < 1 || val > 5))
            {
                throw statusException;
            }
            _course = val;
        }

        protected Level _status;
        /// <summary>
        /// Статус обучения
        /// </summary>
        public Level Status
        {
            get { return _status; }
        }

        protected int _course;
        /// <summary>
        /// Курс студента
        /// </summary>
        public int Course
        {
            get { return _course; }
            set
            {
                int val = value;
                if (Status == Level.bachelor && (val < 1 || val > 4))
                {
                    throw statusException;
                }
                if(Status== Level.master&&(val < 1 || val > 2))
                {
                    throw statusException;
                }
                if(Status == Level.specialist&& (val < 1 || val > 5))
                {
                    throw statusException;
                }
                _course = val;
            }
        }

        /// <summary>
        /// Тип статуса обучения
        /// </summary>
        public enum Level
        {
            bachelor,
            specialist,
            master
        }
    }
}
