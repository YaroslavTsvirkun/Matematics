using System;

namespace Numerics.Geometry.Point
{
    /// <summary>
    /// Класс Point2D описывает точку в лвухмерном пространстве                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            
    /// </summary>
    /// <typeparam name="T">Строготипизированный параметр класса</typeparam>
    public class Point2D<T> : Point<T> where T : IConvertible
    {
        /// <summary>
        /// Поле для хранения координати х
        /// </summary>
        protected T x;

        /// <summary>
        /// Поле для хранения координати у 
        /// </summary>
        protected T y;

        /// <summary>
        /// Поле для хранения имени точки
        /// </summary>
        protected String name;

        /// <summary>
        /// Свойство, для хранения координаты Х, доступно только для чтения
        /// </summary>
        public override T X { get => x; }

        /// <summary>
        ///     Свойство, для хранения координаты Y, доступно только для чтения
        /// </summary>
        public override T Y { get => y; }

        /// <summary>
        /// Свойство, для хранения имени точки, доступно только для чтения
        /// </summary>
        public override string Name { get => name; }

        /// <summary>
        /// Свойство Scalar позволяющее умножить координаты на скаляр
        /// </summary>
        public override T Scalar
        {
            set
            {
                ArithmeticFunctions<T>.MultiplyTwo(x, value);
                ArithmeticFunctions<T>.MultiplyTwo(y, value);
            }
        }

        /// <summary>
        /// Индексатор для обращения к полям
        /// </summary>
        /// <param name="i">Индекс поля: 0 - поле Х, 1 - поле Y</param>
        /// <returns>Возращает или записывает значение в поле</returns>
        public override T this[int i]
        {
            get
            {
                if (i == 0) return X;
                else if (i == 1) return Y;
                else throw new Exception("Индекс может быть только 0 или 1");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("Индекс может быть только 0 или 1");
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point2D() { }

        /// <summary>
        /// Конструктор инициализирующий поля x, y
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        public Point2D(T x, T y)
        {
            this.x = x;
            this.y = y;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }
        /// <summary>
        /// Конструктор инициализирующий поля x, y
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        /// <param name="name">Имя точки</param>
        public Point2D(T x, T y, String name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        /// <summary>
        /// Конструктор инициализирующий имя точки
        /// </summary>
        /// <param name="name">Имя точки</param>
        public Point2D(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Метод Show выводит координаты точки на экран
        /// </summary>
        public override void Show() => Console.WriteLine($"({x}, {y})");

        /// <summary>
        /// Метод GetDistance расчитывает растояния между двумя точками
        /// </summary>
        /// <param name="other">Ссылка на точку</param>
        /// <returns>Возращает растояние между точками</returns>
        public override T GetDistance(Point<T> other)
        {
            T x = ArithmeticFunctions<T>.MultiplyTwo(ArithmeticFunctions<T>.SubtractTwo(this.X, other.X), 
                ArithmeticFunctions<T>.SubtractTwo(this.X, other.X));
            T y = ArithmeticFunctions<T>.MultiplyTwo(ArithmeticFunctions<T>.SubtractTwo(this.Y, other.Y), 
                ArithmeticFunctions<T>.SubtractTwo(this.Y, other.Y));

            var result = Math.Sqrt(Convert.ToDouble(ArithmeticFunctions<T>.AddTwo(x, y)));

            return (T)Convert.ChangeType(result, typeof(T));
        }

        /// <summary>
        /// Метод Transfer перемещения точки на вектор (а, b)
        /// </summary>
        /// <param name="a">Начало и конец вектора задается массивом точек с помощью координат</param>
        public override void Transfer(params Point<T>[] a) 
        {
            ArithmeticFunctionsExcellent<T, Point<T>>.AddTwo(x, a[0]);
            ArithmeticFunctionsExcellent<T, Point<T>>.AddTwo(y, a[1]);
        }

        /// <summary>
        /// Метод Equals осуществляет проверку на существование точек с одними и теми же координатами
        /// </summary>
        /// <param name="p">Массив точек</param>
        /// <returns>Возращает true или false</returns>
        public override bool Equal(Point<T> p)
        {
            if (BooleanFunctions<T, T, Boolean>.Equals(this.X, p.X) && BooleanFunctions<T, T, Boolean>.Equals(this.Y, p.Y)) return true;
            else return false;
        }

        /// <summary>
        /// Перегрузка бинарного оператора " * "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который умножается</param>
        /// <param name="scalar">Параметер на который умножают</param>
        /// <returns>Возращает умноженое значение</returns>
        public static Point2D<T> operator *(Point2D<T> p, T scalar) => new Point2D<T>(
            ArithmeticFunctions<T>.MultiplyTwo(p.X, scalar), ArithmeticFunctions<T>.MultiplyTwo(p.Y, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " + "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, к которому прибавляют</param>
        /// <param name="scalar">Параметер который прибавляют</param>
        /// <returns>Возращает сложеное значение</returns>
        public static Point2D<T> operator +(Point2D<T> p, T scalar) => new Point2D<T>(
            ArithmeticFunctions<T>.AddTwo(p.X, scalar), ArithmeticFunctions<T>.AddTwo(p.Y, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " - "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, с которого вычитают</param>
        /// <param name="scalar">Параметер который вычитают</param>
        /// <returns>Возращает уменшеное значение</returns>
        public static Point2D<T> operator -(Point2D<T> p, T scalar) => new Point2D<T>(
            ArithmeticFunctions<T>.SubtractTwo(p.X, scalar), ArithmeticFunctions<T>.SubtractTwo(p.Y, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " / "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который делят</param>
        /// <param name="scalar">Параметер на который делят</param>
        /// <returns>Возращает разделенное значение</returns>
        public static Point2D<T> operator /(Point2D<T> p, T scalar) => new Point2D<T>(
            ArithmeticFunctions<T>.DivideTwo(p.X, scalar), ArithmeticFunctions<T>.DivideTwo(p.Y, scalar));

        /// <summary>
        /// Перегрузка унарного оператора " ++ "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который инкрементируют</param>
        /// <returns>Возращает инкрементированое значение</returns>
        public static Point3D<T> operator ++(Point2D<T> p) => new Point4D<T>(ArithmeticFunctionsExcellent<T, Int32>.AddTwo(p.X, 1),
            ArithmeticFunctionsExcellent<T, Int32>.AddTwo(p.Y, 1));

        /// <summary>
        /// Перегрузка унарного оператора " -- "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который декрементируют</param>
        /// <returns>Возращает декрементирровааное</returns>
        public static Point2D<T> operator --(Point2D<T> p) => new Point3D<T>(ArithmeticFunctionsExcellent<T, Int32>.SubtractTwo(p.X, 1),
            ArithmeticFunctionsExcellent<T, Int32>.SubtractTwo(p.Y, 1));

        /// <summary>
        /// Перегрузка бинарного оператора " == "
        /// </summary>
        /// <param name="a">Ссылка на экземпляр класса</param>
        /// <param name="b">Ссылка на экземпляр класса</param>
        /// <returns>Возвращает значение true, если поле x = y, иначе false</returns>
        public static Boolean operator ==(Point2D<T> a, Point2D<T> b) => BooleanFunctions<T, T, Boolean>.Equals(a.X, b.X);

        /// <summary>
        /// Перегрузка бинарного оператора " != "
        /// </summary>
        /// <param name="a">Ссылка на экземпляр класса</param>
        /// <param name="b">Ссылка на экземпляр класса</param>
        /// <returns>Возвращает значение true, если поле x != y, иначе false</returns>
        public static Boolean operator !=(Point2D<T> a, Point2D<T> b) => BooleanFunctions<T, T, Boolean>.NotEquals(a.X, b.X);

        //
        /// <summary>
        /// Перегрузка унарной константы true
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса</param>
        /// <returns>Возращает true, если все поля равны</returns>
        public static Boolean operator true(Point2D<T> p) => BooleanFunctions<T, T, Boolean>.Equals(p.X, p.Y);

        /// <summary>
        /// Перегрузка унарной константы false
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса</param>
        /// <returns>Возращает false, если все поля неравны</returns>
        public static Boolean operator false(Point2D<T> p) => BooleanFunctions<T, T, Boolean>.NotEquals(p.X, p.Y);

        /// <summary>
        /// Метод Equals позволяет сравнивать два объекта Point4D
        /// </summary>
        /// <param name="obj">Объект с которым сравнивают</param>
        /// <returns>Возращает true или false</returns>
        public override Boolean Equals(object obj)
        {
            if (!(obj is Point2D<T>)) return false;
            return GetHashCode() == ((Point2D<T>)obj).GetHashCode();
        }

        /// <summary>
        /// Метод GetHashCode генерирует хэш-код экземпляра класса
        /// </summary>
        /// <returns>Возращает хэш-код</returns>
        public override Int32 GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}