using System;
using System.Linq;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace Numerics
{
    /// <summary>
    /// Класс BooleanFunctions предоставляет ряд булевых операций,
    /// таких как: больше, больше чем, равно, не равно, меньше, меньше чем
    /// для переменного количества аргументов от 2-х до 5-ти
    /// </summary>
    /// <typeparam name="T">Тип данных входящих значений</typeparam>
    /// <typeparam name="T2">Тип данных входящих значений</typeparam>
    /// <typeparam name="Boolean">Тип данных возращаемого значения</typeparam> 
    public static class BooleanFunctions<T, T2, Boolean>
    {
        /// <summary>
        /// Позволяет производить операцию сравнения "меньше чем"
        /// </summary>
        public static Func<T, T2, Boolean> Less { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => LessThan(a, b));

        /// <summary>
        /// Позволяет производить операцию сравнения "меньше или равно"
        /// </summary>
        public static Func<T, T2, Boolean> LessThanOrEquals { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => LessThanOrEqual(a, b));

        /// <summary>
        /// Позволяет производить операцию сравнения "больше чем"
        /// </summary>
        public static Func<T, T2, Boolean> Greater { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => GreaterThan(a, b));

        /// <summary>
        /// Позволяет производить операцию сравнения "больше или равно"
        /// </summary>
        public static Func<T, T2, Boolean> GreaterThanOrEquals { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => GreaterThanOrEqual(a, b));

        /// <summary>
        /// Позволяет производить операцию сравнения "равно"
        /// </summary>
        public static new Func<T, T2, Boolean> Equals { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => Equal(a, b));

        /// <summary>
        /// Позволяет производить операцию сравнения "не равно"
        /// </summary>
        public static Func<T, T2, Boolean> NotEquals { get; set; } = TreeGenerator<T, T2, Boolean>.BooleanExpressionToFunc((a, b) => NotEqual(a, b));
    }
}