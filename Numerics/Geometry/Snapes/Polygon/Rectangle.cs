using Numerics.Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Geometry.Snapes.Polygon
{
    /// <summary>
    /// Класс Rectangle описывает прямоугольник
    /// </summary>
    class Rectangle : APolygon
    {
        /// <summary>
        /// Поля хранящие значения сторон прямоугольника
        /// </summary>
        private Int32 a, b;

        private Point2D<Int32> pointOne;
        private Point2D<Int32> pointTwo;
        private Point2D<Int32> pointThree;
        private Point2D<Int32> pointFoor;

        // Конструктор 1
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Конструктор для инициализации полей прямоугольника
        /// </summary>
        /// <param name="a">Сторона прямоугольника</param>
        /// <param name="b">Сторона прямоугольника</param>
        public Rectangle(Int32 a, Int32 b)
        {
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// Конструктор для инициализации вершин прямоугольника
        /// </summary>
        /// <param name="x1">Первая координата первой точки</param>
        /// <param name="y1">Вторая координата первой точки</param>
        /// <param name="x2">Первая координата второй точки</param>
        /// <param name="y2">Вторая координата второй точки</param>
        /// <param name="x3">Первая координата третьей точки</param>
        /// <param name="y3">Вторая координата третьей точки</param>
        /// <param name="x4">Первая координата четвортой точки</param>
        /// <param name="y4">Вторая координата четвортой точки</param>
        public Rectangle(Int32 x1, Int32 y1, Int32 x2, Int32 y2, Int32 x3, Int32 y3, Int32 x4, Int32 y4)
        {
            pointOne = new Point2D<Int32>(x1, y1, "A");
            pointTwo = new Point2D<Int32>(x2, y2, "B");
            pointThree = new Point2D<Int32>(x3, y3, "C");
            pointFoor = new Point2D<Int32>(x4, y4, "D");
        }

        public Rectangle(Int32 a)
        {

        }

        /// <summary>
        /// Метод Perimeter расчитывает периметр прямоугольника
        /// </summary>
        /// <returns>Возращает периметер прямоугольника</returns>
        public override Int32 Perimeter() => 2 * (a + b);

        /// <summary>
        /// Метод Area расчитывает площадь прямоугольника
        /// </summary>
        /// <returns>Возращает площадь прямоугольника</returns>
        public override Int32 Area() => a * b;

        /// <summary>
        /// Метод Correct производит проверку на положительность сторон прямоугольника
        /// </summary>
        /// <param name="a">Сторона прямоугольника</param>
        /// <param name="b">Сторона прямоугольника</param>
        public void Correct(Double a, Double b)
        {
            if (a < 0 || b < 0) throw new Exception();
        }
        
        /// <summary>
        /// Свойство для получения-установления длины стороны а
        /// </summary>
        private int A
        {
            get { return a; }
            set { a = value; }
        }

        /// <summary>
        /// Свойство для получения-установления длины стороны b
        /// </summary>
        private Int32 B
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// Свойство получения информации о том не являеться ли прямоугольник квадратом
        /// </summary>
        public Boolean Square
        {
            get
            {
                if (a > b || b > a) return true;
                else return false;
            }
        }

        /// <summary>
        /// Индексатор для доступа к сторонам триугольника по индексам через свойства
        /// </summary>
        /// <param name="i">Индекс указывающий на стороны прямоугольника</param>
        /// <returns>Возращает указанную сторону прямоугольника</returns>
        public Int32 this[Int32 i]
        {
            get
            {
                if (i == 0) return A;
                else if (i == 1) return B;
                else throw new Exception("Индекс может быть только 0 или 1");
            }
            set
            {
                if (i == 0) A = value;
                else if (i == 1) B = value;
                else throw new Exception("Индекс может быть только 0 или 1");
            }
        }

        /// <summary>
        /// Перегрузка бинарного оператора " * "
        /// </summary>
        /// <param name="p">Ссылка на стороны прямоугольника</param>
        /// <param name="scalar">Скалярное значение</param>
        /// <returns></returns>
        public static Rectangle operator *(Rectangle p, Int32 scalar) => new Rectangle(p.a * scalar, p.b * scalar);

        // 
        /// <summary>
        /// Перегрузка унарного оператора " ++ "
        /// </summary>
        /// <param name="p">Ссылка на стороны прямоугольника</param>
        /// <returns>Возращает увеличеные стороны прямоугольника</returns>
        public static Rectangle operator ++(Rectangle p) => new Rectangle(++p.a, ++p.b);

        /// <summary>
        /// Перегрузка унарного оператора " -- "
        /// </summary>
        /// <param name="p">Ссылка на стороны прямоугольника</param>
        /// <returns>Возращает уменьшенные стороны прямоугольника</returns>
        public static Rectangle operator --(Rectangle p) => new Rectangle(--p.a, --p.b);

        /// <summary>
        /// Перегрузка унарной константы true
        /// </summary>
        /// <param name="p">Ссылка на стороны прямоугольника</param>
        /// <returns>Возращает true если это прямоугольник</returns>
        public static bool operator true(Rectangle p) => p.Square;

        /// <summary>
        /// Перегрузка унарной константы false
        /// </summary>
        /// <param name="p">Ссылка на стороны прямоугольника</param>
        /// <returns>Возращает false если это квадрат</returns>
        public static bool operator false(Rectangle p) => p.Square;
    }
}