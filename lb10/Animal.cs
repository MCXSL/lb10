using System;
using System.Collections.Generic;
using System.Linq;
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
            _Name = "Ник";
            _Age = 4;
            _WeightLast3Mounth = Generation_weight(_WeightLast3Mounth);
            _Type = "Собака";
            _NumberPhone = "+79630991494";
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
            _WeightLast3Mounth = Generation_weight(_WeightLast3Mounth);
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
            _WeightLast3Mounth = Generation_weight(_WeightLast3Mounth);
            _Type = "Собака";
            _NumberPhone = "+79630991494";
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
        /// Генератор веса животного за 3 месяца
        /// </summary>
        /// <param name="arr">Вес животного за 3 месяца(пустой массив)</param>
        /// <returns>Вес животного за 3 месяца(заполненый массив)</returns>
        protected static double[] Generation_weight(double[] arr)
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

        /// <summary>
        /// Конвертатор в double массив
        /// </summary>
        /// <param name="a">первый элемент массива</param>
        /// <param name="b">второй элемент массива</param>
        /// <param name="c">третий элемент массива</param>
        /// <returns>double массив</returns>
        public static double[] ConvToArr(string a, string b, string c)
        {
            double[] arr = { Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)};
            return arr;
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

        private static string EnterArr(double[] arr)
        {
            string str = " ";
            for (int i = 0;i < arr.Length;i++)
            {
                str = arr[i].ToString() + "   ";
            }
            return str;
        }

        public static string FormingString(Animal a)
        {
            string str = $"Имя : {a._Name}; Возраст : {a._Age}; Вес за 3 месяца : {EnterArr(a._WeightLast3Mounth)}; Вид : {a._Type}; Номер телефона хозяина : {a._NumberPhone}";
            return str;
        }
    }
}
