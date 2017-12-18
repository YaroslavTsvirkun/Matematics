using System;
using System.Collections.Generic;
using Numerics.Geometry.Point;

namespace Numerics.Algorithms.Search.FindShortestPaths.Dekstra
{
    /// <summary>
    /// Класс PrintGrath выводит граф на экран
    /// </summary>
    /// <example> 
    /// Вызывающий код класса, <see cref="PrintGrath"/> представлен ниже:
    /// <code>
    /// class TestClass 
    /// {
    ///     static void Main() 
    ///     {
    ///        List(string) b = PrintGrath.PrintAllMinPaths(da);
    ///     }
    /// }
    /// </code>
    /// </example>
    public static class PrintGrath
    {
        /// <summary>
        /// Метод PrintAllPoints выводит вершины графа на экран
        /// </summary>
        /// <param name="da">Ссылка на алгоритм</param>
        /// <returns>ВОзращает вершины графа</returns>
        public static List<String> PrintAllPoints(DekstraAlgorithm da)
        {
            List<String> retListOfPoints = new List<String>();
            foreach (Point p in da.Points)
            {
                retListOfPoints.Add(String.Format($"Имя вершины: = {p.Name}, Значение вершины: = {p.ValueMetka}, Соседи вершины: = {p.PredPoint.Name}" ?? "нет соседей!"));
            }
            return retListOfPoints;
        }

        /// <summary>
        /// Метод PrintAllMinPaths выводит минимальный пути для вершин графа
        /// </summary>
        /// <param name="da">Ссылка на алгоритм</param>
        /// <returns>Возращает минимальные пути для вершин графа</returns>
        public static List<String> PrintAllMinPaths(DekstraAlgorithm da)
        {
            List<String> retListOfPointsAndPaths = new List<String>();
            foreach (Point p in da.Points)
            {
                if (p != da.BeginPoint)
                {
                    String s = String.Empty;
                    foreach (Point p1 in da.MinPath(p))
                    {
                        s += String.Format($"{p1.Name}");
                    }
                    retListOfPointsAndPaths.Add(String.Format($"Вершина: = {p.Name}, Найменьший путь к вершине: {da.BeginPoint.Name} = {s}"));
                }
            }
            return retListOfPointsAndPaths;
        }

        /// <summary>
        /// Метод Show выводит список на экран
        /// </summary>
        /// <param name="list">Список элементов</param>
        public static void Show(List<String> list)
        {
            foreach (var item in list) Console.WriteLine(item);
        }
    }
}