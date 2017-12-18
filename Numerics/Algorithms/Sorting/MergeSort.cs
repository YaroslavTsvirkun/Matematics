using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Numerics.Algorithms.Sorting
{
    /// <summary>
    /// Класс MergeSort реализует алгоритм сортировки слиянием
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        /// Метод MSort сортирует коллекцию элементов, за время:
        /// лучшое: O(n*log(n)),
        /// в среднем: O(n*log(n)),
        /// в худшем: O(n*log(n)).
        /// </summary>
        /// <typeparam name="T">Строготипизированный параметер метода, указывающий тип элементов коллекции</typeparam>
        /// <param name="list">Коллекция элементов</param>
        /// <returns>Возращает отсортированную коллекцию элементов</returns>
        public static IEnumerable<T> Sort<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            if (!list.Any()) return Enumerable.Empty<T>();
            IEnumerable<T> first = list.Skip(0).Where((item) => list.Count() / 2 + 1 > list
                .Count() - 1 || (0 <= list.Count() / 2 + 1 && BooleanFunctions<T, T, Boolean>
                .Less(list.ElementAt(0), list.ElementAt(list.Count() / 2 + 1))));
            IEnumerable<T> second = list.Skip(list.Count() / 2 + 1).Where(item => list
                .Count() / 2 + 1 > list.Count() - 1 || (0 <= list.Count() / 2 + 1 && BooleanFunctions<T, T, Boolean>
                .Less(list.ElementAt(list.Count() / 2 + 1), list.ElementAt(list.Count() - 1))));
            return first.Concat(second).OrderBy(u => u);
        }
    }
}