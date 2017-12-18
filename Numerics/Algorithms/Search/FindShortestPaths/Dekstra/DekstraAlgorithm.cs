using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerics.Algorithms.Search.FindShortestPaths.Dekstra
{
    /// <summary>
    /// Класс DekstraAlgorithm предоставляет собой граф и логику алгоритма Дейкстры
    /// </summary>
    /// <example> 
    /// Вызывающий код класса, <see cref="DekstraAlgorithm"/> представлен ниже:.
    /// <code>
    /// class TestClass 
    /// {
    ///     static void Main() 
    ///     {
    ///         DekstraAlgorithm da = new DekstraAlgorithm(v, rebras);
    ///         da.Run(v[0]);
    ///     }
    /// }
    /// </code>
    /// </example>
    public class DekstraAlgorithm
    {
        /// <summary>
        /// Свойство, для хранения вершин графа
        /// </summary>
        public Point[] Points { get; private set; }

        /// <summary>
        /// Свойство, для хранения ребер графа
        /// </summary>
        public Ribs[] Ribs { get; private set; }

        /// <summary>
        /// Свойство, для хранения начальной вершины графа
        /// </summary>
        public Point BeginPoint { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Points">Массив вершин графа</param>
        /// <param name="Ribs">Массив ребер графа</param>
        public DekstraAlgorithm(Point[] Points, Ribs[] Ribs)
        {
            this.Points = Points;
            this.Ribs = Ribs;
        }

        /// <summary>
        /// Метод Run запускает алгоритм расчета
        /// </summary>
        /// <param name="begin">Начальная точка, откуда наченается расчет</param>
        public void Run(Point begin)
        {
            if (this.Points.Count() == 0 || this.Ribs.Count() == 0) throw new DekstraException("Массив вершин или ребер не задан!");
            else
            {
                BeginPoint = begin;
                OneStep(begin);
                foreach (Point point in Points)
                {
                    Point anotherP = GetAnotherUncheckedPoint();
                    if (anotherP != null) OneStep(anotherP);
                    else break;
                }
            }
        }

        /// <summary>
        /// Метод OneStep делает один шаг алгоритма
        /// </summary>
        /// <param name="begin">Принимает на вход вершину графа</param>
        public void OneStep(Point begin)
        {
            foreach (Point nextp in Ancestor(BeginPoint))
            {
                if (nextp.IsChecked == false)//не отмечена
                {
                    Single newmetka = BeginPoint.ValueMetka + GetRebro(nextp, BeginPoint).Weight;
                    if (nextp.ValueMetka > newmetka)
                    {
                        nextp.ValueMetka = newmetka;
                        nextp.PredPoint = BeginPoint;
                    }
                    else { }
                }
            }
            BeginPoint.IsChecked = true;//вычеркиваем
        }

        /// <summary>
        /// Метод Ancestor находит соседей для заданой точки
        /// </summary>
        /// <param name="currpoint">Вершина графа</param>
        /// <returns>Возращает колекцию соседних вершин</returns>
        private IEnumerable<Point> Ancestor(Point currpoint)
        {
            IEnumerable<Point> firstpoints = from ff in Ribs where ff.FirstPoint == currpoint select ff.SecondPoint;
            // IEnumerable<Point> first = Ribs.Where<Ribs>(n => n.FirstPoint == currpoint).Select(n => n.SecondPoint);
            IEnumerable<Point> secondpoints = from sp in Ribs where sp.SecondPoint == currpoint select sp.FirstPoint;
            // IEnumerable<Point> second = Ribs.Where<Ribs>(n => n.SecondPoint == currpoint).Select(n => n.FirstPoint);
            IEnumerable<Point> totalpoints = firstpoints.Concat<Point>(secondpoints);
            return totalpoints;
        }

        /// <summary>
        /// Метод GetRebro получаем ребро, соединяющее 2 входные точки
        /// </summary>
        /// <param name="a">Первая входная точка</param>
        /// <param name="b">Вторая входная точка</param>
        /// <returns></returns>
        private Ribs GetRebro(Point a, Point b)
        {
            //ищем ребро по 2 точкам
            IEnumerable<Ribs> myr = from reb in Ribs where (reb.FirstPoint == a & reb.SecondPoint == b) || (reb.SecondPoint == a & reb.FirstPoint == b) select reb;
            // IEnumerable<Ribs> my = Ribs.Where(n => n.FirstPoint == a & n.SecondPoint == b || n.SecondPoint == a & n.FirstPoint == b).Select(n => n);
            if (myr.Count() > 1 || myr.Count() == 0) throw new DekstraException("Не найдено ребро между соседями!");
            else return myr.First();
        }

        /// <summary>
        /// Метод GetAnotherUncheckedPoint получает очередную неотмеченную вершину, "ближайшую" к заданной.
        /// </summary>
        /// <returns></returns>
        private Point GetAnotherUncheckedPoint()
        {
            IEnumerable<Point> pointsuncheck = from p in Points where p.IsChecked == false select p;
            // IEnumerable<Point> point = Points.Where<Point>(n => n.IsChecked == false).Select(n => n);
            if (pointsuncheck.Count() != 0)
            {
                Single minVal = pointsuncheck.First().ValueMetka;
                Point minPoint = pointsuncheck.First();
                foreach (Point p in pointsuncheck)
                {
                    if (p.ValueMetka < minVal)
                    {
                        minVal = p.ValueMetka;
                        minPoint = p;
                    }
                }
                return minPoint;
            }
            else return null;
        }

        /// <summary>
        /// Метод MinPath находит пути от начальной до конечной вершины
        /// </summary>
        /// <param name="end">Конечная вершина минимального пути</param>
        /// <returns>Возращает кратчайший путь</returns>
        public List<Point> MinPath(Point end)
        {
            List<Point> listOfpoints = new List<Point>();
            Point tempp = new Point();
            tempp = end;
            while (tempp != this.BeginPoint)
            {
                listOfpoints.Add(tempp);
                tempp = tempp.PredPoint;
            }
            return listOfpoints;
        }
    }
}