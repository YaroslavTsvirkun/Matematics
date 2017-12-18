using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Numbers
{
    /// <summary>
    /// Класс NumberNumbers предназначен для работы с числами
    /// </summary>
    public static class NumberNumbers
    {
        /// <summary>
        /// Метод Numbers производит проверку чисел на кратность числу n
        /// </summary>
        /// <param name="numbers">Числа которые проходят проверку на кратность</param>
        /// <param name="n">Число кратности, по умолчанию 2</param>
        /// <returns>Возращает от фильтрованный массив чисел кратных n</returns>
        public static Int32[] Numbers(Int32[] numbers, Int32 n = 2)
        {
            Int32[] num = new Int32[numbers.Length];
            for (Int32 i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % n == 0) num[i] = numbers[i];
            }
            return num;
        }
    }
}