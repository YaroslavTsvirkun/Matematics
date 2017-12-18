using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Numbers.PrimeNumbers
{
    /// <summary>
    /// Класс MersennesNumbers определяет простые числа Мерсенна
    /// </summary>
    public static class MersennesNumbers
    {
        // mn = 2 ^ n - 1
        /// <summary>
        /// Метод GetMersennes производит расчет простых четных чисел Марсена
        /// </summary>
        /// <param name="n">Четное число больше нуля</param>
        /// <returns>Возращает массив простых чисел Марсена</returns>
        public static Int32[] GetMersennes(this Int32[] n)
        {
            Int32[] f = null;
            for(Int32 i = 0; i < n.Count(); i++)
            {
                if (n[i] % 2 == 0) f[i] += ArithmeticFunctions<Int32>.PowTwo(2, n[i]) - 1;
            }
            return f;
        }
    }
}