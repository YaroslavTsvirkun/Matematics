using System;
using System.Linq;
using System.Collections.Generic;

namespace HomeworkOne
{
    /// <summary>
    /// Класс ExpansionArray предоставляет методы расширения для работы с массивами
    /// </summary>
    public static class ExtensionArray
    {
        /// <summary>
        /// Метод IntputArray позволяет ввести элементы массива с клавиатуры
        /// </summary>
        /// <param name="intArray">Ссылка на экземпляр массива</param>
        /// <returns></returns>
        public static Int32[] IntputArray(this Int32[] intArray)
        {
            Console.Write("Укажите размер массива: ");
            Int32 n = Convert.ToInt32(Console.ReadLine());
            intArray = new Int32[n];
            for (int i = 0; i < intArray.Count(); i++)
            {
                Console.Write($"IntArray [{i}]: ");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return intArray;
        }

        /// <summary>
        /// Метод Print<T> выводит элементы массива на экран
        /// </summary>
        /// <typeparam name="T">Тип параметра</typeparam>
        /// <param name="array">Ссылка на экземпляр массива</param>
        public static void Print<T>(this T[] array)
        {
            foreach (T ar in array)
            {
                Console.Write($"{ar}" + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод Print<T> выводит элементы массива на экран
        /// </summary>
        /// <typeparam name="T">Тип параметра</typeparam>
        /// <param name="array">Ссылка на экземпляр массива</param>
        public static void Print<T>(List<T> array)
        {
            foreach (var ar in array)
            {
                Console.Write($"{ar}" + " ");
            }
            Console.WriteLine();
        }
    }
}