using Expansions;
using System.Collections.Generic;
using System.Linq;

namespace Numerics.DiscreteMath.Data
{
    /// <summary>
    ///     Class definition to save the unoriented юgraph.
    /// </summary>
    public class GraphInfo
    {
        /// <summary>
        ///     Name of the graph.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     An adjacency list to hold our graph data
        /// </summary>
        public List<GraphVertexInfo> GraphVertexInfos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public GraphInfo(string name)
        {
            Name = name;
            GraphVertexInfos = new List<GraphVertexInfo>();
        }

        /// <summary>
        ///     Adds a new vertex to the graph
        /// </summary>
        /// <param name="vertex">The new vertex</param>
        /// <returns>Returns the success of the operation</returns>
        public bool AddVertex(GraphVertexInfo vertex)
        {
            if (TryGraphVertexInfo(vertex, out var graphVertexInfo)) return false;

            GraphVertexInfos.Add(graphVertexInfo);
            return true;
        }

        /// <summary>
        ///    Remove vertex to the graph
        /// </summary>
        /// <param name="vertex">The remove vertex</param>
        /// <returns>Returns the success of the operation</returns>
        public bool RemoveVertex(GraphVertexInfo vertex)
        {
            if (!TryGraphVertexInfo(vertex, out var graphVertexInfo)) return false;

            graphVertexInfo.GraphEdgeInfos.ForEach(edge =>
            {
                GraphVertexInfos.ForEach(v =>
                {
                    v.GraphEdgeInfos.Remove(edge);
                });
            });

            graphVertexInfo.GraphEdgeInfos.Clear();
            GraphVertexInfos.Remove(graphVertexInfo);

            return true;
        }

        /// <summary>
        ///     Adds a new edge to vertice in the graph
        /// </summary>
        /// <param name="vertex">The vertex</param>
        /// <param name="edge">The edge</param>
        /// <returns>Returns the success of the operation</returns>
        public bool AddEdge(GraphVertexInfo vertex, GraphEdgeInfo edge)
        {
            if (TryGraphVertexInfo(vertex, out var graphVertexInfo)) return false;

            graphVertexInfo.AddEdge(edge);

            GraphVertexInfos.Update(vertex, graphVertexInfo);

            return true;
        }

        /// <summary>
        ///     Remove edge from vertices in the graph
        /// </summary>
        /// <param name="vertex">The vertex</param>
        /// <param name="edge">The edge</param>
        /// <returns>Returns the success of the operation</returns>
        public bool RemoveEdge(GraphVertexInfo vertex, GraphEdgeInfo edge)
        {
            if (!TryGraphVertexInfo(vertex, out var graphVertexInfo)) return false;

            graphVertexInfo.RemoveEdge(edge);

            GraphVertexInfos.Update(vertex, graphVertexInfo);

            return true;
        }

        public GraphVertexInfo FindVertexInfoByEdgeInfo(GraphEdgeInfo graphEdgeInfo)
        {
            return GraphVertexInfos.Find(x => x.Position.Equal(graphEdgeInfo.SecondPoint));
        }

        public bool TryGraphVertexInfo(GraphVertexInfo graphVertexInfo, out GraphVertexInfo searchVertexInfo)
        {
            searchVertexInfo = GraphVertexInfos.FirstOrDefault(x => x.Name == graphVertexInfo.Name);

            if (searchVertexInfo != null) return true;

            searchVertexInfo = graphVertexInfo;

            return false;
        }
    }
}