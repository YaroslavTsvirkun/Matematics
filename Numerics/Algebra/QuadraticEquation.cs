using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Algebra
{
    /// <summary>
    /// Класс QuadraticEquation содержит логику решения алгебраического 
    /// квадратного уровнения общего вида
    /// </summary>
    public static class QuadraticEquation
    {
        /// <summary>
        /// Метод QuadraticEquationFunc производит решение квадратного уровнения
        /// </summary>
        /// <param name="a">Первый коэффициент</param>
        /// <param name="b">Второй коэффициент</param>
        /// <param name="c">Свободный член</param>
        /// <returns>Возращает массив коэфициентов</returns>
        public static Double[] QuadraticEquationFunc(Double a, Double b, Double c)
        {
            Double d = ArithmeticFunctions<Double>
                .DivideTwo(ArithmeticFunctions<Double>
                .MultiplyTwo(b, b), ArithmeticFunctionsExcellent<Double, Double>
                .MultiplyTwo(ArithmeticFunctionsExcellent<Double, Int32>
                .MultiplyTwo(a, 4), c));

            if (d > 0)
            {
                Double x1 = (-b + Math.Sqrt(d)) / 2 / a;
                Double x2 = (-b - Math.Sqrt(d)) / 2 / a;
                return new Double[] { x1, x2 };
            }
            else if (d == 0)
            {
                Double x1 = b / 2 / a;
                Double x2 = b / 2 / a;
                return new Double[] { x1, x2 };
            }
            return null;
        }
    }
}