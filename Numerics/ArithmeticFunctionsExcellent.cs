using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;
using System.Threading.Tasks;

namespace Numerics
{
    /// <summary>
    /// Класс ArithmeticFunctionsExcellent предоставляет ряд арефмитических операций,
    /// таких как сложение, вычитание, умножение, деления, деление с остатком, 
    /// для 2-х аргументов, позволяющих обрабатывать тип данных Т и отличный тип данных от Т
    /// </summary>
    /// <typeparam name="T">Первый строготипизированный тип класса</typeparam>
    /// <typeparam name="T2">Второй строготипизированный тип класса, отличный от Т</typeparam>
    public static class ArithmeticFunctionsExcellent<T, T2>
    {
        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> AddTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Add(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> AddCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => AddChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания сложения для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> AddAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => AddAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания сложения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> AddAssignCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => AddAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> SubtractTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Subtract(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> SubtractCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => SubtractChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания вычитания для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> SubtractAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => SubtractAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания вычитания для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> SubtractAssignCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => SubtractAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> MultiplyTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Multiply(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> MultiplyCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => MultiplyChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания умножения для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> MultiplyAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => MultiplyAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания умножения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T2, T> MultiplyAssignCheckedTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => MultiplyAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> DivideTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Divide(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания деления для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> DivideAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => DivideAssign(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> ModuloTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Modulo(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания деления с остатком для двух слагаемых
        /// </summary>
        public static Func<T, T2, T> ModuloAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => ModuloAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию возведения в степень
        /// </summary>
        public static Func<T, T2, T> PowTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => Power(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию возведения в степень с присваиванием значения текущему выражению
        /// </summary>
        public static Func<T, T2, T> PowAssignTwo { get; set; } = TreeGenerator<T, T2>.ExpressionToFunc((a, b) => PowerAssign(a, b));
    }

    /// <summary>
    /// Класс ArithmeticFunctionsExcellent предоставляет ряд арефмитических операций,
    /// таких как сложение, вычитание, умножение, деления, деление с остатком, 
    /// для 2-х аргументов, позволяющих обрабатывать тип данных Т и отличный тип данных от Т
    /// </summary>
    /// <typeparam name="T1">Первый строготипизированный тип класса</typeparam>
    /// <typeparam name="T2">Второй строготипизированный тип класса, отличный от Т1</typeparam>
    /// <typeparam name="T3">Третий строготипизированный тип класса, отличный от Т1</typeparam>
    public static class ArithmeticFunctionsExcellent<T1, T2, T3>
    {
        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для двух слагаемых
        /// </summary>
        public static Func<T1, T2, T3> ModuloTwo { get; set; } = TreeGenerator<T1, T2, T3>.ArithmeticExpressionToFunc((a, b, c) => Modulo(a, b));
    }
}