using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Geometry.Snapes
{
    /// <summary>
    /// Класс Snape описывает характеристики фигуры
    /// </summary>
    public abstract class Snape
    {
        /// <summary>
        /// Метод Perimeter расчитывает периметер фигуры
        /// </summary>
        /// <returns>Возращает периметер фигуры</returns>
        public abstract Int32 Perimeter();

        /// <summary>
        /// Метод Area расчитывает площадь фигуры
        /// </summary>
        /// <returns>Возращает площадь фигуры</returns>
        public abstract Int32 Area();
    }
}