using System;

namespace Numerics.Algorithms.Search.FindShortestPaths.Dekstra
{
    /// <summary>
    /// Класс DekstraException отвечающий за обработку исключитильных ситуаций в алгоритме Дейкстры
    /// </summary>
    class DekstraException : ApplicationException
    {
        public DekstraException(String message) : base(message) { }
    }
}