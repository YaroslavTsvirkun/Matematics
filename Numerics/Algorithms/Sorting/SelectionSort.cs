using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Algorithms.Sorting
{
    /// <summary>
    /// Класс SelectionSort реализует алгоритм сортировки выбором 
    /// </summary>
    public static class SelectionSort
    {
        /// <summary>
        /// Метод Sort сортирует коллекцию элементов, за время:
        /// лучшое: O(n^2),
        /// в среднем: O(n^2),
        /// в худшем: O(n^2).
        /// </summary>
        /// <typeparam name="T">Строготипизированный параметер метода, указывающий тип элементов коллекции</typeparam>
        /// <param name="list">Коллекция элементов</param> 
        /// <returns>Возращает отсортированную коллекцию элементов</returns>
        public static IEnumerable<T> Sort<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            if (!list.Any()) return Enumerable.Empty<T>();
            IEnumerable<T> first = list.Where((item, j) => BooleanFunctions<T, T, Boolean>.Equals(list.ElementAt(j + 1), list.ElementAt(j))).Select(y => y).Sort();
            IEnumerable<T> a = from item in list
                               let minValue = list.Min()
                               let minIndex = Array.FindIndex(list.ToArray(), x => BooleanFunctions<T, T, Boolean>.Equals(x, minValue))
                               where BooleanFunctions<T, Int32, Boolean>.Less(list.ToArray()[minIndex + 1], minIndex)

                               orderby item
                               select item;
            return first;
        }
    }
}