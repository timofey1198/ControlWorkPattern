
namespace Test_my_speed_1
{
    /// <summary>
    /// Класс человека
    /// </summary>
    public class Person
    {
        static MyRandom rnd = new MyRandom();
        public Person(string name, string surname, uint age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _age = (uint)rnd.Next(0, 100, MyRandom.Boundary.include, MyRandom.Boundary.include);
        }

        public Person() { }

        protected string _name;
        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        protected string _surname;
        /// <summary>
        /// Фамилия человека
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }

        }

        protected uint _age;
        /// <summary>
        /// Возраст человека
        /// </summary>
        public uint Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
