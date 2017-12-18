using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Algorithms.Search.FindShortestPaths.Dekstra
{
    /// <summary>
    /// Класс Ribs описывающий ребра графа
    /// </summary>
    /// <example> 
    /// Вызывающий код класса, <see cref="Ribs"/> представлен ниже:.
    /// <code>
    /// class TestClass 
    /// {
    ///     static void Main() 
    ///     {
    ///        Ribs[] rebras = new Ribs[10];
    ///        rebras[0] = new Ribs(v[0], v[2], 8);
    ///        rebras[1] = new Ribs(v[0], v[3], 4);//FC
    ///        rebras[2] = new Ribs(v[0], v[1], 9);//FA
    ///        rebras[3] = new Ribs(v[2], v[3], 7);//bc
    ///        rebras[4] = new Ribs(v[2], v[5], 5);//be
    ///        rebras[5] = new Ribs(v[3], v[5], 5);//ce
    ///        rebras[6] = new Ribs(v[1], v[5], 6);//ae
    ///        rebras[7] = new Ribs(v[1], v[4], 5);//ad
    ///        rebras[8] = new Ribs(v[3], v[4], 4);//cd
    ///        rebras[9] = new Ribs(v[2], v[4], 7);//bd
    ///     }
    /// }
    /// </code>
    /// </example>
    public class Ribs
    {
        /// <summary>
        /// Свойство, отвечает за хранение начальной вершины ребра
        /// </summary>
        public Point FirstPoint { get; private set; }

        /// <summary>
        /// Свойство, отвечает за хранение конечной вершины ребра
        /// </summary>
        public Point SecondPoint { get; private set; }

        /// <summary>
        /// Свойство, отвечает за хранение весового коэффициента
        /// </summary>
        public Single Weight { get; private set; }

        /// <summary>
        /// Конструктор, отвечающий за инициализацию начальной вершины ребра,
        /// конечной вершины ребра весового коэффициента
        /// </summary>
        /// <param name="FirstPoint">Начальная вершина</param>
        /// <param name="SecondPoint">Конечная вершина</param>
        /// <param name="Weight">Весовой коэффициент</param>
        public Ribs(Point FirstPoint, Point SecondPoint, Single Weight)
        {
            this.FirstPoint = FirstPoint;
            this.SecondPoint = SecondPoint;
            this.Weight = Weight;
        }
    }
}