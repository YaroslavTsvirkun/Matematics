using Numerics.Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Numerics.DiscreteMath.Data
{
    /// <summary>
    ///     Class definition to save the vertex.
    /// </summary>
    public class GraphVertexInfo
    {
        /// <summary>
        ///     Name of the vertex.
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        ///     Edges associated with the vertex.
        /// </summary>
        public List<GraphEdgeInfo> GraphEdgeInfos { get; set; }

        /// <summary>
        ///     Property responsible for storing the coordinates vertex
        /// </summary>
        public Point2D<int> Position { get; set; }

        /// <summary>
        ///     Creates a new vertex with empty edges.
        /// </summary>
        /// <param name="name">Name of the vertex.</param>
        public GraphVertexInfo(String name)
        {
            Name = name;
            GraphEdgeInfos = new List<GraphEdgeInfo>();
        }

        /// <summary>
        ///     Creates a new vertex.
        /// </summary>
        /// <param name="name">Name of the vertex.</param>
        /// <param name="graphEdgeInfo">Array of the edge.</param>
        public GraphVertexInfo(String name, GraphEdgeInfo[] graphEdgeInfo) : this(name)
        {
            GraphEdgeInfos = graphEdgeInfo.ToList();
        }

        /// <summary>
        ///     Adds a new edge vertices in the graph
        /// </summary>
        /// <param name="edge">The edge</param>
        /// <returns>Returns the success of the operation</returns>
        public bool AddEdge(GraphEdgeInfo edge)
        {
            if (GraphEdgeInfos.Any(v => v.Name == edge.Name)) return false;

            GraphEdgeInfos.Add(edge);

            return true;
        }

        /// <summary>
        ///     Remove edge from vertices in the graph
        /// </summary>
        /// <param name="edge">The edge</param>
        /// <returns>Returns the success of the operation</returns>
        public bool RemoveEdge(GraphEdgeInfo edge)
        {
            if (GraphEdgeInfos.Any(e => e.Name == edge.Name && !(e.FirstPoint.Equal(edge.FirstPoint) || e.SecondPoint.Equal(edge.SecondPoint)))) return false;

            GraphEdgeInfos.Remove(edge);

            return true;
        }
    }
}