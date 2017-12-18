using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace Numerics.Numbers.PrimeNumbers
{
    /// <summary>
    /// Класс FermatNumbers опредиляет простые числа Ферма
    /// </summary>
    public static class FermatNumbers
    {
        /// <summary>
        /// Метод GetFermat производит расчет простых чисел Ферма
        /// </summary>
        /// <param name="n">Неотрицательное целое число</param>
        /// <returns>Возращает простые числа Ферма</returns>
        public static Int32[] GetFermat(this Int32[] n)
        {
            Int32[] f = null;
            for (Int32 i = 0; i < n.Count(); i++)
            {
                if(n[i] >= 0) f[i] = ArithmeticFunctions<Int32>.PowTwo(2, ArithmeticFunctions<Int32>.PowTwo(2, n[i])) + 1;
            }
            return f;
        }
    }
}