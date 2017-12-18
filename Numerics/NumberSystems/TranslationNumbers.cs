using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numerics.Type;

namespace Numerics.NumberSystems
{
    /// <summary>
    /// Класс TranslationNumbers для перевода чисел с разных систем исчесления
    /// </summary>
    public class TranslationNumbers
    {
        
        /// <summary>
        /// Метод DecimalToBinary осуществляет перевод чисел с десятиричной в двоичную систему исчесления
        /// </summary>
        /// <typeparam name="Type">Входящее десятиричное число</typeparam>
        /// <returns>Возращает двоичное представление десятиричного числа</returns>
        public Int32 DecimalToBinary<Type>(Type type)
        {
            Type modulo;
            BinarySystem<Type> binary = new BinarySystem<Type>();
            try
            {
                while (BooleanFunctions<Type, Int32, Boolean>.Greater(type, 0))
                {
                    modulo = ArithmeticFunctionsExcellent<Type, Int32>.ModuloTwo(type, 2);
                    type = ArithmeticFunctionsExcellent<Type, Int32>.DivideTwo(type, 2);
                    binary.Binary.Add(modulo);
                }
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.InnerException);
            }
            Int32 Back(List<Type> norm)
            {
                Type[] s = new Type[norm.Count()];
                for (Int32 i = norm.Count() - 1; i >= 0; i--) s[norm.Count() - 1 - i] = norm[i];
                return Convert.ToInt32(String.Join<Type>("", s));
            }
            return Back(binary.Binary);
        }

        /// <summary>
        /// Метод BinaryToDecimal осуществляет перевод чисел с двоичной в десятиричную систему исчесления
        /// </summary>
        /// <param name="type">Входящее двоичное число</param>
        /// <typeparam name="Type">Входящий тип данных</typeparam>
        /// <typeparam name="Return">Возращаемый тип данных</typeparam>
        /// <returns>Возращает десятиричное представление двоичного числа</returns>
        public Int32 BinaryToDecimal<Type, Return>(BinarySystem<Type> type) 
        {
            return 0;
        }

        private Int32 Count<Type>(Type num, Int32 seed, Int32 modulo) where Type : struct
        {
            if (BooleanFunctions<Type, Int32, Boolean>.NotEquals(ArithmeticFunctionsExcellent<Type, Int32>.DivideTwo(num, modulo), 0))
            {
                return Count(ArithmeticFunctionsExcellent<Type, Int32>.DivideTwo(num, modulo), seed++, modulo);
            }
            else return seed;
        }
    }
}
