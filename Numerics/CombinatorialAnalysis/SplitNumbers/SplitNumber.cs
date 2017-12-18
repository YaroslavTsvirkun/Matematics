using System;
using static System.Math;

namespace Numerics.CombinatorialAnalysis.SplitNumbers
{
    /// <summary>
    /// Класс SplitNumber предоставляет n в виде суммы положительных целых чисел
    /// </summary>
    public static class SplitNumber
    {
        /// <summary>
        /// Метол AsymptoticExpressionHardyRamanujan предоставляет асимптотическое выражение для количества разбиений числа n,
        /// было получено Харди и Рамануджаном
        /// </summary>
        /// <param name="n">Число n</param>
        /// <returns>Возращает количество разбиений числа n</returns>
        public static Double AsymptoticExpressionHardyRamanujan(Int64 n) => (Exp(PI * Sqrt(2/3) * Sqrt(n - (1/24)))) / (4 * n * Sqrt(3));


        
    }
}