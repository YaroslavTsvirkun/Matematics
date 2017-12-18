using Numerics.Geometry.Point;
using System;

namespace Numerics.Algorithms.Search.FindShortestPaths.Dekstra
{
    /// <summary>
    /// Класс Point описывающий вершины графа
    /// </summary>
    /// <example> 
    /// Вызывающий код класса, <see cref="Point"/> представлен ниже:
    /// <code>
    /// class TestClass 
    /// {
    ///     static void Main() 
    ///     {
    ///        Point[] v = new Point[6];
    ///        v[0] = new Point(0, false, "F");
    ///        v[1] = new Point(9999, false, "A");
    ///        v[2] = new Point(9999, false, "B");
    ///        v[3] = new Point(9999, false, "C");
    ///        v[4] = new Point(9999, false, "D");
    ///        v[5] = new Point(9999, false, "E");
    ///     }
    /// }
    /// </code>
    /// </example>
     public class Point : Point2D<String>
    {
        /// <summary>
        /// Свойство, отвечающее за хранение значений метки данной вершины
        /// </summary>
        public Single ValueMetka { get; set; }

        /// <summary>
        /// Свойство, отвечает за хранение значение помечена метка или нет
        /// </summary>
        public Boolean IsChecked { get; set; }

        /// <summary>
        /// Свойство, отвечает за хранение предка вершины
        /// </summary>
        public Point PredPoint { get; set; }

        /// <summary>
        /// Свойство, отвечает за хранение некого объекта
        /// </summary>
        public Object SomeObj { get; set; }

        /// <summary>
        /// Конструктор, отвечающий за инициализацию значений метки, 
        /// за отметку метки и вершины графа
        /// </summary>
        /// <param name="ValueMetka">Значение метки</param>
        /// <param name="IsChecked">Помечена метка или нет</param>
        public Point(Int32 ValueMetka, Boolean IsChecked)
        {
            this.ValueMetka = ValueMetka;
            this.IsChecked = IsChecked;
            PredPoint = new Point();
        }

        /// <summary>
        /// Конструктор, отвечающий за инициализацию значений метки, за отметку метки, 
        /// имени метки и вершины графа
        /// </summary>
        /// <param name="ValueMetka">Значение метки</param>
        /// <param name="IsChecked">Помечена метка или нет</param>
        /// <param name="name">Имя метки</param>
        public Point(Int32 ValueMetka, Boolean IsChecked, String name) : base(name)
        {
            this.ValueMetka = ValueMetka;
            this.IsChecked = IsChecked;
            PredPoint = new Point();
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point() { }
    }
}