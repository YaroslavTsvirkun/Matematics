using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkOne
{
    /// <summary>
    /// Класс ExpansionString предоставляет методы расширения для работы со строками
    /// </summary>
    public static class ExpansionString
    {
        /// <summary>
        /// Метод ReversStr перестраивает строку в обратном порядке
        /// </summary>
        /// <param name="str">Ссылка на экземпляр строки</param>
        /// <returns>Возращает строку в обратном порядке</returns>
        public static String ReversStr(this String str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        /// <summary>
        /// Метод GetCharLength ищет самую длиную последовательность символов в строке
        /// </summary>
        /// <param name="line">Ссылка на экземпляр строки</param>
        /// <returns></returns>
        public static IEnumerable<Int32> GetCharLength(this String str)
        {
            for (Int32 i = 0, n = 1; i < str.Count() - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    n++;
                }
                else
                {
                    yield return n;
                    n = 1;
                }
                if (i == str.Length - 2)
                {
                    yield return n;
                }
            }
        }
    }
}