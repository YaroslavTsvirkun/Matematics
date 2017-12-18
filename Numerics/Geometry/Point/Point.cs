using System;
using System.Linq.Expressions;

namespace Numerics.Geometry.Point
{
    /// <summary>
    /// Абстрактный класс Point для описания точки в пространстве
    /// </summary>
    /// <typeparam name="T">Строготипизированный параметр класса</typeparam>
    public abstract class Point<T> : IPoint3D<T>, IPoint4D<T> where T : IConvertible
    {
        /// <summary>
        /// Свойство для хранения первого значения координнаты
        /// </summary>
        public abstract T X { get; }

        /// <summary>
        /// Свойство для хранения другого значения координнаты
        /// </summary>
        public abstract T Y { get; }

        /// <summary>
        /// Свойство для хранения третьего значения координнаты
        /// </summary>
        public T Z { get; }

        /// <summary>
        /// Свойство для хранения четвертого значения координнаты
        /// </summary>
        public T A { get; }

        /// <summary>
        /// Свойство, для хранения имени точки
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// Свойство, предоставляющее операцию арифмитического умножения
        /// </summary>

        /// <summary>
        /// Метод Show предназначен для вывода координат на консоль
        /// </summary>
        public abstract void Show();

        /// <summary>
        /// Метод GetDistance предназначен для расчета растояния между точками
        /// </summary>
        /// <param name="other">Точка до которой нужно расчитать растояние</param>
        /// <returns></returns>
        public abstract T GetDistance(Point<T> other);

        /// <summary>
        /// Метод Transfer перемещения точки на вектор (а,b)
        /// </summary>
        /// <param name="a">Начало и конец вектора задается массивом точек с помощью координат</param>
        public abstract void Transfer(params Point<T>[] a);

        /// <summary>
        /// Свойство Scalar позволяющее умножить координаты на скаляр
        /// </summary>
        public abstract T Scalar { set; }

        /// <summary>
        /// Метод Equals осуществляет проверку на существование точек с одними и теми же координатами
        /// </summary>
        /// <param name="p">Массив точек</param>
        /// <returns>Возращает true или false</returns>
        public abstract Boolean Equal(Point<T> p);

        /// <summary>
        /// Индексатор для обращения к полям
        /// </summary>
        /// <param name="i">Индекс поля</param>
        /// <returns>Возращает или записывает значение в поле</returns>
        public abstract T this[Int32 i] { get; set; }
    }
}