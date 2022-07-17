using Numerics.Geometry.Point;
using System;

namespace Numerics.DiscreteMath.Data
{
    /// <summary>
    ///     Class definition to save the edge.
    /// </summary>
    public class GraphEdgeInfo
    {
        /// <summary>
        ///     Name of the edge.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     Property responsible for storing the initial vertex of the edge
        /// </summary>
        public Point2D<int> FirstPoint { get; private set; }

        /// <summary>
        ///     Property responsible for storing the end vertex of the edge
        /// </summary>
        public Point2D<int> SecondPoint { get; private set; }

        /// <summary>
        ///     Property responsible for storing the weighting factor(И
        /// </summary>
        public Single Weight { get; private set; }

        /// <summary>
        ///     Constructor responsible for initializing the start vertex of the edge, the end vertex of the edge of the weight coefficient
        /// </summary>
        /// <param name="nameEdge">Nmae edge</param>
        /// <param name="FirstPoint">Start point</param>
        /// <param name="SecondPoint">End point</param>
        /// <param name="Weight">Weight coefficient</param>
        public GraphEdgeInfo(string nameEdge, Point2D<int> FirstPoint, Point2D<int> SecondPoint, Single Weight)
        {
            this.Name = nameEdge;
            this.FirstPoint = FirstPoint;
            this.SecondPoint = SecondPoint;
            this.Weight = Weight;
        }
    }
}