using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{
    internal class Animal
    {
        private string _Name;
        private int _Age;
        private double[] _WeightLast3Mounth = new double[3];
        private string _Type;
        private string _NumberPhone;
        private static int _NumberOfAnimals = 0;

        /// <summary>
        /// Конструктор класса без параметров
        /// </summary>
        public Animal()
        {
            _Name = GenerationName();
            _Age = GenerationAge();
            _WeightLast3Mounth = Generationweight(_WeightLast3Mounth);
            _Type = GenerationType();
            _NumberPhone = GenerationNumberPhone();
            _NumberOfAnimals++;
        }

        /// <summary>
        /// Конструктор класса с одним параметром
        /// </summary>
        /// <param name="name">Кличка животного</param>
        public Animal(string name)
        {
            _Name = name;
            _Age = 4;
            _WeightLast3Mounth = Generationweight(_WeightLast3Mounth);
            _Type = "Собака";
            _NumberPhone = "+79630991494";
            _NumberOfAnimals++;
        }

        /// <summary>
        /// Конструктор класса с двумя параметрами
        /// </summary>
        /// <param name="name">Кличка животного</param>
        /// <param name="age">Возраст животного</param>
        public Animal(string name, int age)
        {
            _Name = name;
            _Age = age;
            _WeightLast3Mounth = Generationweight(_WeightLast3Mounth);
            _Type = "Собака";
            _NumberPhone = "+79630991494";
            _NumberOfAnimals++;
        }

        /// <summary>
        /// Конструктор класса со всеми параметрами кроме статического
        /// </summary>
        /// <param name="name">Кличка животного</param>
        /// <param name="age">Возраст</param>
        /// <param name="weightLast3Mounth">Вес за последние 3 месяца</param>
        /// <param name="type">Вес животного</param>
        /// <param name="numberPhone">Номер телефона владельца</param>
        public Animal(string name, int age, double[] weightLast3Mounth, string type, string numberPhone)
        {
            _Name = name;
            _Age = age;
            _WeightLast3Mounth = weightLast3Mounth;
            _Type = type;
            _NumberPhone = numberPhone;
            _NumberOfAnimals++;
        }

        /// <summary>
        /// Конструктор класса со всеми параметрами
        /// </summary>
        /// <param name="name">Кличка животного</param>
        /// <param name="age">Возраст</param>
        /// <param name="weightLast3Mounth">Вес за последние 3 месяца</param>
        /// <param name="type">Вес животного</param>
        /// <param name="numberPhone">Номер телефона владельца</param>
        /// <param name="number">Кол-во созданных объектов</param>
        public Animal(string name, int age, double[] weightLast3Mounth, string type, string numberPhone, int number)
        {
            _Name = name;
            _Age = age;
            _WeightLast3Mounth = weightLast3Mounth;
            _Type = type;
            _NumberPhone = numberPhone;
            _NumberOfAnimals = number;
        }

        protected static string GenerationName()
        {
            string[] moreName= {"Бобик", "Вася", "Том", "Толя", "Мила", "Ника", "Пушинка"};
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int a = rnd.Next(0, 6);
            return moreName[a];
        }

        protected static int GenerationAge()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int a = rnd.Next(1, 18);
            return a;
        }

        /// <summary>
        /// Генератор веса животного за 3 месяца
        /// </summary>
        /// <param name="arr">Вес животного за 3 месяца(пустой массив)</param>
        /// <returns>Вес животного за 3 месяца(заполненый массив)</returns>
        /// 

        protected static double[] Generationweight(double[] arr)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < arr.Length; i++)
            {
                int a = rnd.Next(3, 30);
                double b = rnd.Next(1, 99);
                arr[i] = a + (b / 100);
            }
            return arr;
        }

        private static string GenerationType()
        {
            string[] moreType = { "кошка", "собака"};
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int a = rnd.Next(0, 1);
            return moreType[a];
        }

        protected static string GenerationNumberPhone()
        {
            string str = "";
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 8; i++)
            {
                str += rnd.Next(0, 9);
            }
            return str;
        }

        /// <summary>
        /// Конвертация в double массив
        /// </summary>
        /// <param name="strings">Массив строк</param>
        /// <returns>double массив</returns>
        public static double[] ConvToArr(string [] strings)
        {
            double[] arr = new double[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                arr[i] = Convert.ToDouble(strings[i]);
            }
            return arr;
        }

        /// <summary>
        /// Проверка веса на корректтность
        /// </summary>
        /// <param name="strings">Вес</param>
        /// <returns>Вердикт проверки</returns>
        public static bool CheackWeightLast3Mounth(string[] strings)
        {
            double[] arr = new double[strings.Length];
            bool logic = false;
            for (int i = 0;i < arr.Length;i++) 
            {
                if (double.TryParse(strings[i], out arr[i]))
                {
                    logic = true;
                }
                else
                {
                    logic = false;
                    break;
                }
            }
            return logic;
        }

        /// <summary>
        /// Проверка возраста
        /// </summary>
        /// <param name="str"> возраст</param>
        /// <returns>Вердикт проверки</returns>
        public static bool CheackAge(string str)
        {
            int a;
            bool logic = false;
            if (int.TryParse(str, out a))
            {
                logic = true;
            }
            else
            {
                logic = false;
            }
            return logic;
        }

        /// <summary>
        /// Вывод кол-ва экземпляров
        /// </summary>
        /// <returns>кол-во экземпляров</returns>
        public static string EnterNumberAnimals() 
        {
            string str = Animal._NumberOfAnimals.ToString();
            return str;
        }

        /// <summary>
        /// Запись массива в строку
        /// </summary>
        /// <param name="arr"> Массив </param>
        /// <returns>Строка</returns>
        public static string EnterArr(double[] arr)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString();
                if (i < arr.Length - 1)
                str += "; ";
            }
            return str;
        }

        /// <summary>
        /// Формировка строки для вывода
        /// </summary>
        /// <param name="a">Экземпляр классса</param>
        /// <returns>Строка</returns>
        public static string[] FormingString(Animal a)
        {
            string[] strs = { a._Name , a._Age.ToString(), EnterArr(a._WeightLast3Mounth), a._Type, a._NumberPhone };
            return strs;
        }

        public static string[] UnformingWeight(string str)
        {
            const int numberOfMonths = 3;
            string[] arr = new string[numberOfMonths];
            char[] chars = str.ToCharArray();
            int j = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    j++;
                }
                else if (chars[i] == ';')
                {}
                else
                {
                    arr[j] += chars[i];
                }
            }
            return arr;
        }

        /// <summary>
        /// Расформировка строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Массив строк</returns>
        public static string[] UnformingString(string str)
        {
            char[] chars = str.ToCharArray();
            string reservStr = "";
            string[] arr = new string[7];
            int j = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if ((chars[i] == ';' || chars[i] == '|') && reservStr != "")
                {
                    arr[j] = reservStr;
                    j++;
                    reservStr = "";
                }
                else if (chars[i] == ' ')
                {

                }
                else
                {
                    reservStr += chars[i];
                }
            }
            return arr;
        }

    }
}
