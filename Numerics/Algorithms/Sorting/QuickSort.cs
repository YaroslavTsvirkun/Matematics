using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerics.Algorithms.Sorting
{
    /// <summary>
    /// Класс QuickSort реализует алгоритм быстрой сортировки
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        /// Метод QSort сортирует коллекцию элементов, за время:
        /// лучшое: O(n*log(n)),
        /// в среднем: O(n*log(n)),
        /// в худшем: O(n^2).
        /// </summary>
        /// <typeparam name="T">Строготипизированный параметер метода, указывающий тип элементов коллекции</typeparam>
        /// <param name="list">Коллекция элементов</param>
        /// <returns>Возращает отсортированную коллекцию элементов</returns>
        public static IEnumerable<T> QSort<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            if (!list.Any()) return Enumerable.Empty<T>();
            T pivot = list.First();
            IEnumerable<T> smaller = list.Skip(1).Where((item) => item.CompareTo(pivot) <= 0).QSort();
            IEnumerable<T> larger = list.Skip(1).Where((item) => item.CompareTo(pivot) > 0).QSort();
            return smaller.Concat(new[] { pivot }).Concat(larger);
        }
    }
}