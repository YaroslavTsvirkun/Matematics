using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.Linq.Expressions.Expression;

namespace Numerics
{
    /// <summary>
    /// Класс ArithmeticFunctions предоставляет ряд арефмитических операций,
    /// таких как сложение, вычитание, умножение, деления, деление с остатком, 
    /// для переменного количества аргументов от 2-х до 5-ти
    /// </summary>
    /// <typeparam name="T">Тип данных класса</typeparam>
    public static class ArithmeticFunctions<T>
    {
        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для двух слагаемых
        /// </summary>
        public static Func<T, T, T> AddTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Add(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> AddCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => AddChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания сложения для двух слагаемых
        /// </summary>
        public static Func<T, T, T> AddAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => AddAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания сложения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> AddAssignCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => AddAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для двух слагаемых
        /// </summary>
        public static Func<T, T, T> SubtractTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Subtract(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> SubtractCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => SubtractChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания вычитания для двух слагаемых
        /// </summary>
        public static Func<T, T, T> SubtractAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => SubtractAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания вычитания для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> SubtractAssignCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => SubtractAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для двух слагаемых
        /// </summary>
        public static Func<T, T, T> MultiplyTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Multiply(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> MultiplyCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => MultiplyChecked(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания умножения для двух слагаемых
        /// </summary>
        public static Func<T, T, T> MultiplyAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => MultiplyAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания умножения для двух слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T> MultiplyAssignCheckedTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => MultiplyAssignChecked(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления для двух слагаемых
        /// </summary>
        public static Func<T, T, T> DivideTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Divide(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания деления для двух слагаемых
        /// </summary>
        public static Func<T, T, T> DivideAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => DivideAssign(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для двух слагаемых
        /// </summary>
        public static Func<T, T, T> ModuloTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Modulo(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию присваивания деления с остатком для двух слагаемых
        /// </summary>
        public static Func<T, T, T> ModuloAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => ModuloAssign(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию возведения в степень
        /// </summary>
        public static Func<T, T, T> PowTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => Power(a, b));

        /// <summary>
        /// Позволяет производить арефметическую операцию возведения в степень с присваиванием значения текущему выражению
        /// </summary>
        public static Func<T, T, T> PowAssignTwo { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b) => PowerAssign(a, b));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для трех слагаемых
        /// </summary>
        public static Func<T, T, T, T> AddThree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => Add(Add(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для трех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T> AddCheckedThree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => AddChecked(AddChecked(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для трех слагаемых
        /// </summary>
        public static Func<T, T, T, T> SubtractThree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => Subtract(Subtract(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для трех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T> SubtractCheckedThree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => SubtractChecked(SubtractChecked(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для трех слагаемых
        /// </summary>
        public static Func<T, T, T, T> MultiplyTree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => Multiply(Multiply(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для трех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T> MultiplyCheckedTree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => MultiplyChecked(MultiplyChecked(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления для трех слагаемых
        /// </summary>
        public static Func<T, T, T, T> DivideTree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => Divide(Divide(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для трех слагаемых
        /// </summary>
        public static Func<T, T, T, T> ModuloTree { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c) => Modulo(Modulo(a, b), c));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для четырех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T> AddFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => Add(Add(a, b), Add(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для четырех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T> AddCheckedFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => AddChecked(AddChecked(a, b), AddChecked(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для четырех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T> SubtractFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => Subtract(Subtract(a, b), Subtract(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для четырех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T> SubtractCheckedFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => SubtractChecked(SubtractChecked(a, b), SubtractChecked(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для четырех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T> MultiplyFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => Multiply(Multiply(a, b), Multiply(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для четырех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T> MultiplyCheckedFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => MultiplyChecked(MultiplyChecked(a, b), MultiplyChecked(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления для четырех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T> DivideFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => Divide(Divide(a, b), Divide(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для четырех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T> ModuloFoor { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d) => Modulo(Modulo(a, b), Modulo(c, d)));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для пятех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T, T> AddFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => Add(Add(Add(a, b), Add(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию сложения для пятех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T, T> AddCheckedFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => AddChecked(AddChecked(AddChecked(a, b), AddChecked(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для пятех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T, T> SubtractFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => Subtract(Subtract(Subtract(a, b), Subtract(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию вычитания для пятех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T, T> SubtractCheckedFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => SubtractChecked(SubtractChecked(SubtractChecked(a, b), Expression.SubtractChecked(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для пятех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T, T> MultiplyFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => Multiply(Multiply(Multiply(a, b), Multiply(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию умноженя для пятех слагаемых, с проверкой переполнения
        /// </summary>
        public static Func<T, T, T, T, T, T> MultiplyCheckedFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => MultiplyChecked(MultiplyChecked(MultiplyChecked(a, b), Expression.MultiplyChecked(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления для пятех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T, T> DivideFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => Divide(Divide(Divide(a, b), Divide(c, d)), e));

        /// <summary>
        /// Позволяет производить арефмитическую операцию деления с остатком для пятех слагаемых
        /// </summary>
        public static Func<T, T, T, T, T, T> ModuloFive { get; set; } = TreeGenerator<T>.ExpressionToFunc((a, b, c, d, e) => Modulo(Modulo(Modulo(a, b), Modulo(c, d)), e));
    }
}