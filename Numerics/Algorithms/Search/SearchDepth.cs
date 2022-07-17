using Numerics.DiscreteMath.Data;
using System.Collections.Generic;
using System.Linq;

namespace Numerics.Algorithms.Search
{
    /// <summary>
    ///     The class represents a graph depth-first search
    /// </summary>
    public class SearchDepth
    {
        private readonly GraphInfo _graphInfo;

        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="graphVertexInfos">Graph</param>
        public SearchDepth(GraphInfo graphVertexInfos)
        {
            _graphInfo = graphVertexInfos;
        }

        /// <summary>
        ///     Recursively traverse the graph and return an array of vertex names
        /// </summary>
        /// <param name="startVertex">The starting vertex from where the traversal should start.</param>
        /// <returns>Returns array of strings</returns>
        public List<string> DFSRecursive(GraphVertexInfo startVertex)
        {
            if (!_graphInfo.TryGraphVertexInfo(startVertex, out var graphVertexInfo)) return Enumerable.Empty<string>().ToList();

            List<string> result = new List<string>();

            HashSet<GraphVertexInfo> visitedVertexInfo = new HashSet<GraphVertexInfo>();

            DFSR(graphVertexInfo, result, visitedVertexInfo);
            return result;
        }

        /// <summary>
        ///     Iteratively traverse the graph and return an array of vertex names
        /// </summary>
        /// <param name="startVertex">The starting vertex from where the traversal should start.</param>
        /// <returns>Returns array of strings</returns>
        public List<string> DFSIterative(GraphVertexInfo startVertex)
        {
            if (!_graphInfo.TryGraphVertexInfo(startVertex, out var graphVertexInfo)) return Enumerable.Empty<string>().ToList();

            List<string> result = new List<string>();
            HashSet<GraphVertexInfo> visitedVertexInfo = new HashSet<GraphVertexInfo>();
            Stack<GraphVertexInfo> stack = new Stack<GraphVertexInfo>();
            stack.Push(graphVertexInfo);

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                if (visitedVertexInfo.Contains(current)) continue;
                result.Add(current.Name);
                visitedVertexInfo.Add(current);

                foreach (var neighbor in current.GraphEdgeInfos)
                {
                    var nextVertexInfo = _graphInfo.FindVertexInfoByEdgeInfo(neighbor);

                    if (!visitedVertexInfo.Contains(nextVertexInfo))
                    {
                        stack.Push(nextVertexInfo);
                    }
                }
            }
            return result;
        }

        private void DFSR(GraphVertexInfo startVertex, List<string> result, HashSet<GraphVertexInfo> visitedVertexInfo)
        {
            if (startVertex == null || visitedVertexInfo.Contains(startVertex)) return;

            result.Add(startVertex.Name);

            visitedVertexInfo.Add(startVertex);

            foreach (GraphEdgeInfo neighbor in startVertex.GraphEdgeInfos)
            {
                var nextVertexInfo = _graphInfo.FindVertexInfoByEdgeInfo(neighbor);

                if (!visitedVertexInfo.Contains(nextVertexInfo))
                {
                    DFSR(nextVertexInfo, result, visitedVertexInfo);
                }
            }
        }
    }
}