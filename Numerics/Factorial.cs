using System;
using System.Numerics;

namespace Numerics
{
    /// <summary>
    /// Класс Factorial определяет факторил числа и ряд других операций с факториалом числа
    /// </summary>
    public static class Factorial<Type>  
    {
        /// <summary>
        /// Метод GetFactorial определяет факториал числа n!
        /// </summary>
        /// <param name="n">n! - факториал</param>
        /// <returns>Возращает факториал числа</returns>
        public static Int64 GetFactorial(Int64 n)
        {
            Int64 factorial = 1;
            for(Int64 i = 1; i <= n; i++)
            {
                factorial = ArithmeticFunctions<Int64>.MultiplyTwo(factorial, i);
            }
            return factorial;
        }

        /// <summary>
        /// Метод SumFactorial определяет сумму цифр факториала числа n!
        /// </summary>
        /// <param name="n">n! - факториал</param>
        /// <returns>Возращает сумму цифр числа n!</returns>
        public static Int64 SumFactorial(Int64 n)
        {
            Int64 sum = 0;
            do{
                sum = ArithmeticFunctions<Int64>.AddTwo(sum, ArithmeticFunctions<Int64>.ModuloTwo(n, 10));
                n = ArithmeticFunctions<Int64>.DivideAssignTwo(n, 10);
            } while (n > 0);

            return sum;
        }
    }
}