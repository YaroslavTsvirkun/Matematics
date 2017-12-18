using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Numbers
{
    /// <summary>
    /// Класс CatalanNumbers для работы с числами Каталана
    /// </summary>
    class CatalanNumbers
    {
        /// <summary>
        /// Метод CatalanNumber находит числа Каталана
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Int64[] CatalanNumber(Int32 n)
        {
            Int64[] num = new Int64[n + 1];
            num[0] = 1;
            if (n > 0)
            {
                for (Int64 i = 0; i < num.LongLength; i++)
                {
                    num[i + 1] = num[i] * 2 * (2 * i + 1) / (i + 2);
                }
            }
            return num;
        }
    }
}