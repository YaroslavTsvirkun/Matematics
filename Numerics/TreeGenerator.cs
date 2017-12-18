using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;
using System.Threading.Tasks;

namespace Numerics
{
    /// <summary>
    /// Класс TreeGenerator генерирует деревья выражений
    /// </summary>
    /// <typeparam name="T">Строготипизированный параметер класса</typeparam>
    public static class TreeGenerator<T>
    {
        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений для двух аргументов
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        public static Func<T, T, T> ExpressionToFunc(Func<ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T), "a");
            ParameterExpression bp = Parameter(typeof(T), "b");
            Expression<Func<T, T, T>> lambda = Lambda<Func<T, T, T>>(f(ap, bp), ap, bp);
            return lambda.Compile();
        }

        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений для трех выражений
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        public static Func<T, T, T, T> ExpressionToFunc(Func<ParameterExpression, ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T), "a");
            ParameterExpression bp = Parameter(typeof(T), "b");
            ParameterExpression cp = Parameter(typeof(T), "c");
            Expression<Func<T, T, T, T>> lambda = Lambda<Func<T, T, T, T>>(f(ap, bp, cp), ap, bp, cp);
            return lambda.Compile();
        }

        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений для четырех выражений
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        public static Func<T, T, T, T, T> ExpressionToFunc(Func<ParameterExpression, ParameterExpression, ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T), "a");
            ParameterExpression bp = Parameter(typeof(T), "b");
            ParameterExpression cp = Parameter(typeof(T), "c");
            ParameterExpression dp = Parameter(typeof(T), "d");
            Expression<Func<T, T, T, T, T>> lambda = Lambda<Func<T, T, T, T, T>>(f(ap, bp, cp, dp), ap, bp, cp, dp);
            return lambda.Compile();
        }

        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений для пятех выражений
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        internal static Func<T, T, T, T, T, T> ExpressionToFunc(Func<ParameterExpression, ParameterExpression, ParameterExpression, ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T), "a");
            ParameterExpression bp = Parameter(typeof(T), "b");
            ParameterExpression cp = Parameter(typeof(T), "c");
            ParameterExpression dp = Parameter(typeof(T), "d");
            ParameterExpression ep = Parameter(typeof(T), "e");
            Expression<Func<T, T, T, T, T, T>> lambda = Lambda<Func<T, T, T, T, T, T>>(f(ap, bp, cp, dp, ep), ap, bp, cp, dp, ep);
            return lambda.Compile();
        }
    }

    internal static class TreeGenerator<T1, T2>
    {
        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        internal static Func<T1, T2, T1> ExpressionToFunc(Func<ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T1), "a");
            ParameterExpression bp = Parameter(typeof(T2), "b");
            Expression<Func<T1, T2, T1>> lambda = Lambda<Func<T1, T2, T1>>(f(ap, bp), ap, bp);
            return lambda.Compile();
        }
    }

    internal static class TreeGenerator<T1, T2, T3>
    {
        /// <summary>
        /// Метод ExpressionToFunc генерирует дерево выражений
        /// </summary>
        /// <param name="f">Делегат который принимает переменое количество аргументов</param>
        /// <returns>Возращает дерево выражений</returns>
        internal static Func<T1, T2, T3> BooleanExpressionToFunc(Func<ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T1), "a");
            ParameterExpression bp = Parameter(typeof(T2), "b");
            Expression<Func<T1, T2, T3>> lambda = Lambda<Func<T1, T2, T3>>(f(ap, bp), ap, bp);
            return lambda.Compile();
        }

        internal static Func<T1, T2, T3> ArithmeticExpressionToFunc(Func<ParameterExpression, ParameterExpression, ParameterExpression, BinaryExpression> f)
        {
            ParameterExpression ap = Parameter(typeof(T1), "a");
            ParameterExpression bp = Parameter(typeof(T2), "b");
            ParameterExpression cp = Parameter(typeof(T3), "c");
            Expression<Func<T1, T2, T3>> lambda = Lambda<Func<T1, T2, T3>>(f(ap, bp, cp), ap, bp, cp);
            return lambda.Compile();
        }
    }
}