using System;
using System.Collections.Generic;
using System.Linq;
using static System.Linq.Expressions.Expression;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Numerics
{
    /// <summary>
    /// Класс BooleanFunctionsExcellent предоставляет ряд булевых операций,
    /// таких как: больше, больше чем, равно, не равно, меньше, меньше чем
    /// для 2-х єлементов
    /// </summary>
    /// <typeparam name="T1">Тип данных входящих значений</typeparam>
    /// <typeparam name="T2">Тип данных входящих значений</typeparam>
    /// <typeparam name="Boolean">Тип данных возращаемого значения</typeparam>
    public static class BooleanFunctionsExcellent<T1, T2, Boolean>
    {
        /// <summary>
        /// Позволяет производить операцию числового сравнения "больше чем"
        /// </summary>
        public static Func<T1, T2, Boolean> GreaterThan { get; set; } = TreeGenerator<T1, T2, Boolean>.BooleanExpressionToFunc((a, b) => Expression.GreaterThan(a, b));

        /// <summary>
        /// Позволяет производить операцию числового сравнения "больше или равно"
        /// </summary>
        public static Func<T1, T2, Boolean> GreaterThanOrEqual { get; set; } = TreeGenerator<T1, T2, Boolean>.BooleanExpressionToFunc((a, b) => Expression.GreaterThanOrEqual(a, b));

        /// <summary>
        /// Позволяет производить операцию числового сравнения "меньше чем"
        /// </summary>
        public static Func<T1, T2, Boolean> LessThan { get; set; } = TreeGenerator<T1, T2, Boolean>.BooleanExpressionToFunc((a, b) => Expression.LessThan(a, b));

        /// <summary>
        /// Позволяет производить операцию числового сравнения "меньше или равно"
        /// </summary>
        public static Func<T1, T2, Boolean> LessThanOrEqual { get; set; } = TreeGenerator<T1, T2, Boolean>.BooleanExpressionToFunc((a, b) => Expression.LessThanOrEqual(a, b));

        /// <summary>
        /// Позволяет производить операцию числового сравнения "равно"
        /// </summary>
        public static Func<T1, T2, Boolean> Equal { get; set; } = TreeGenerator<T1, T2, Boolean>.BooleanExpressionToFunc((a, b) => Expression.Equal(a, b));
    }
}