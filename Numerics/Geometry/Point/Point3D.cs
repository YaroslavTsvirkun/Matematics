using System;

namespace Numerics.Geometry.Point
{
    /// <summary>
    /// Класс Point3D описывает точку в трехмерном пространстве
    /// </summary>
    /// <typeparam name="T">Строго типизированный параметер</typeparam>
    public class Point3D<T> : Point2D<T>, IPoint3D<T> where T : IConvertible
    {
        /// <summary>
        /// Поле для хранеия координати z
        /// </summary>
        protected T z;

        /// <summary>
        /// Свойство, для хранения координаты Z, доступно только для чтения
        /// </summary>                                                                                                                                                                                                                                     
        public new T Z { get => z; }

        /// <summary>
        /// Закрытое поле value для переопределения метода Equals
        /// и для хранения хэш-кода экземпляра
        /// </summary>
        private Int32 value;


        /// <summary>
        /// Свойство Scalar позволяющее умножить координаты на скаляр
        /// </summary>
        public override T Scalar
        {
            set
            {
                ArithmeticFunctions<T>.MultiplyTwo(x, value);
                ArithmeticFunctions<T>.MultiplyTwo(y, value);
                ArithmeticFunctions<T>.MultiplyTwo(z, value);
            }
        }

        /// <summary>
        /// Индексатор для обращения к полям
        /// </summary>
        /// <param name="i">Индекс поля: 0 - поле Х, 1 - поле Y, 2 - поле Z</param>
        /// <returns>Возращает или записывает значение в поле</returns>
        public override T this[int i]
        {
            get
            {
                if (i == 0) return X;
                else if (i == 1) return Y;
                else if (i == 2) return Z;
                else throw new Exception("Индекс может быть только 0, 1 или 2");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) y = value;
                else throw new Exception("Индекс может быть только 0, 1 или 2");
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Point3D() { }

        /// <summary>
        /// Конструктор инициализирующий поля x, y
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        public Point3D(T x, T y) : base(x, y) { }

        /// <summary>
        /// Конструктор инициализирующий поля x, y, z
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        /// <param name="z">Координата z</param>
        public Point3D(T x, T y, T z) : base(x, y) => this.z = z;

        /// <summary>
        /// Конструктор инициализирующий координаты x, y, z, a и имя точки
        /// </summary>
        /// <param name="x">Координата х</param>
        /// <param name="y">Координата у</param>
        /// <param name="z">Координата z</param>
        /// <param name="name">Имя точки</param>
        public Point3D(T x, T y, T z, String name) : base(x, y, name) => this.z = z;

        /// <summary>
        /// Конструктор инициализирующий имя точки
        /// </summary>
        /// <param name="name"></param>
        public Point3D(String name) => this.name = name;

        /// <summary>
        /// Метод Show выводит координаты точки на экран
        /// </summary>
        public override void Show() => Console.WriteLine($"({x}, {y}, {z})");

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
            T z = ArithmeticFunctions<T>.MultiplyTwo(ArithmeticFunctions<T>.SubtractTwo(this.Z, other.Z),
                ArithmeticFunctions<T>.SubtractTwo(this.Z, other.Z));

            var result = Convert.ToDouble(ArithmeticFunctions<T>.AddThree(x, y, z));

            return (T)Convert.ChangeType(Math.Sqrt(result), typeof(T));
        }

        /// <summary>
        /// Метод Transfer перемещения точки на вектор (а, b, z)
        /// </summary>
        /// <param name="a">Начало и конец вектора задается массивом точек с помощью координат</param>
        public override void Transfer(params Point<T>[] a)
        {
            ArithmeticFunctionsExcellent<T, Point<T>>.AddTwo(x, a[0]);
            ArithmeticFunctionsExcellent<T, Point<T>>.AddTwo(y, a[1]);
            ArithmeticFunctionsExcellent<T, Point<T>>.AddTwo(z, a[2]);
        }

        /// <summary>
        /// Метод Equals осуществляет проверку на существование точек с одними и теми же координатами
        /// </summary>
        /// <param name="p">Массив точек</param>
        /// <returns>Возращает true или false</returns>
        public override Boolean Equal(Point<T> p)
        {
            if (BooleanFunctions<T, T, Boolean>.Equals(this.X, p.X) && BooleanFunctions<T, T, Boolean>.Equals(this.Y, p.Y) && BooleanFunctions<T, T, Boolean>.Equals(this.Z, p.Z))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Перегрузка бинарного оператора " * "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который умножается</param>
        /// <param name="scalar">Параметер на который умножают</param>
        /// <returns>Возращает умноженое значение</returns>
        public static Point3D<T> operator *(Point3D<T> p, T scalar) => new Point3D<T>(
            ArithmeticFunctions<T>.MultiplyTwo(p.X, scalar), ArithmeticFunctions<T>.MultiplyTwo(p.Y, scalar),
            ArithmeticFunctions<T>.MultiplyTwo(p.Z, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " + "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, к которому прибавляют</param>
        /// <param name="scalar">Параметер который прибавляют</param>
        /// <returns>Возращает сложеное значение</returns>
        public static Point3D<T> operator +(Point3D<T> p, T scalar) => new Point3D<T>(
            ArithmeticFunctions<T>.AddTwo(p.X, scalar), ArithmeticFunctions<T>.AddTwo(p.Y, scalar),
            ArithmeticFunctions<T>.AddTwo(p.Z, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " - "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, с которого вычитают</param>
        /// <param name="scalar">Параметер который вычитают</param>
        /// <returns>Возращает уменшеное значение</returns>
        public static Point3D<T> operator -(Point3D<T> p, T scalar) => new Point3D<T>(
            ArithmeticFunctions<T>.SubtractTwo(p.X, scalar), ArithmeticFunctions<T>.SubtractTwo(p.Y, scalar),
            ArithmeticFunctions<T>.SubtractTwo(p.Z, scalar));

        /// <summary>
        /// Перегрузка бинарного оператора " / "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который делят</param>
        /// <param name="scalar">Параметер на который делят</param>
        /// <returns>Возращает разделенное значение</returns>
        public static Point3D<T> operator /(Point3D<T> p, T scalar) => new Point3D<T>(
            ArithmeticFunctions<T>.DivideTwo(p.X, scalar), ArithmeticFunctions<T>.DivideTwo(p.Y, scalar),
            ArithmeticFunctions<T>.DivideTwo(p.Z, scalar));

        /// <summary>
        /// Перегрузка унарного оператора " ++ "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который инкрементируют</param>
        /// <returns>Возращает инкрементированое значение</returns>
        public static Point3D<T> operator ++(Point3D<T> p) => new Point4D<T>(ArithmeticFunctionsExcellent<T, Int32>.AddTwo(p.X, 1),
            ArithmeticFunctionsExcellent<T, Int32>.AddTwo(p.Y, 1), ArithmeticFunctionsExcellent<T, Int32>.AddTwo(p.Z, 1));

        /// <summary>
        /// Перегрузка унарного оператора " -- "
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса, который декрементируют</param>
        /// <returns>Возращает декрементирровааное</returns>
        public static Point3D<T> operator --(Point3D<T> p) => new Point3D<T>(ArithmeticFunctionsExcellent<T, Int32>.SubtractTwo(p.X, 1),
            ArithmeticFunctionsExcellent<T, Int32>.SubtractTwo(p.Y, 1), ArithmeticFunctionsExcellent<T, Int32>.SubtractTwo(p.Z, 1));

        /// <summary>
        /// Перегрузка бинарного оператора " == "
        /// </summary>
        /// <param name="a">Ссылка на экземпляр класса</param>
        /// <param name="b">Ссылка на экземпляр класса</param>
        /// <returns>Возвращает значение true, если поле x = y, иначе false</returns>
        public static Boolean operator ==(Point3D<T> a, Point3D<T> b) => (BooleanFunctions<T, T, Boolean>.Equals(a.X, b.X)) &&
            (BooleanFunctions<T, T, Boolean>.Equals(a.Y, b.Y)) && (BooleanFunctions<T, T, Boolean>.Equals(a.Z, b.Z));

        /// <summary>
        /// Перегрузка бинарного оператора " != "
        /// </summary>
        /// <param name="a">Ссылка на экземпляр класса</param>
        /// <param name="b">Ссылка на экземпляр класса</param>
        /// <returns>Возвращает значение true, если поле x != y, иначе false</returns>
        public static Boolean operator !=(Point3D<T> a, Point3D<T> b) => (BooleanFunctions<T, T, Boolean>.NotEquals(a.X, b.X)) &&
            (BooleanFunctions<T, T, Boolean>.NotEquals(a.Y, b.Y)) && (BooleanFunctions<T, T, Boolean>.NotEquals(a.Z, b.Z));

        //
        /// <summary>
        /// Перегрузка унарной константы true
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса</param>
        /// <returns>Возращает true, если все поля равны</returns>
        public static Boolean operator true(Point3D<T> p) => (BooleanFunctions<T, T, Boolean>.Equals(p.X, p.Y)) &&
            (BooleanFunctions<T, T, Boolean>.Equals(p.X, p.Z)) && (BooleanFunctions<T, T, Boolean>.Equals(p.Y, p.Z));

        /// <summary>
        /// Перегрузка унарной константы false
        /// </summary>
        /// <param name="p">Ссылка на экземпляр класса</param>
        /// <returns>Возращает false, если все поля неравны</returns>
        public static Boolean operator false(Point3D<T> p) => (BooleanFunctions<T, T, Boolean>.NotEquals(p.X, p.Y)) &&
            (BooleanFunctions<T, T, Boolean>.NotEquals(p.X, p.Z)) && (BooleanFunctions<T, T, Boolean>.NotEquals(p.Y, p.Z));

        /// <summary>
        /// Метод Equals позволяет сравнивать два объекта Point4D
        /// </summary>
        /// <param name="obj">Объект с которым сравнивают</param>
        /// <returns>Возращает true или false</returns>
        public override Boolean Equals(object obj)
        {
            if (!(obj is Point3D<T>)) return false;
            return value == ((Point3D<T>)obj).value;
        }

        /// <summary>
        /// Метод GetHashCode генерирует хэш-код экземпляра класса
        /// </summary>
        /// <returns>Возращает хэш-код</returns>
        public override Int32 GetHashCode() => value;
    }
}