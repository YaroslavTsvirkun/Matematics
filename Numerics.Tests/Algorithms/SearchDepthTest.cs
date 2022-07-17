using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numerics.Algorithms.Search;
using Numerics.DiscreteMath.Data;
using Numerics.Geometry.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerics.Tests.Algorithms
{
    [TestClass]
    public class SearchDepthTest
    {
        private static GraphInfo _graphInfo;

        [ClassInitialize]
        public static void Initalize(TestContext context)
        {
            // Undirected Graph
            /**
             *                  Chicago (1)
             *                  |     \
             *                  |      \
             *              Dallas (2)  Atlanta (3)
             *                  |         \
             *                  |          \
             *        (4) San Francisco----Orlando  (5)
             *                   \        /
             *                    \      /
             *                   Las Vegas (6)
             * **/
            _graphInfo = new GraphInfo("Tree");

            GraphVertexInfo graphVertex1 = new GraphVertexInfo("Chicago");
            GraphVertexInfo graphVertex2 = new GraphVertexInfo("Dallas");
            GraphVertexInfo graphVertex3 = new GraphVertexInfo("Atlanta");
            GraphVertexInfo graphVertex4 = new GraphVertexInfo("San Francisco");
            GraphVertexInfo graphVertex5 = new GraphVertexInfo("Orlando");
            GraphVertexInfo graphVertex6 = new GraphVertexInfo("Las Vegas");

            graphVertex1.Position = new Point2D<int>(1, 1, "Chicago");
            graphVertex2.Position = new Point2D<int>(0, 2, "Dallas");
            graphVertex3.Position = new Point2D<int>(1, 2, "Atlanta");
            graphVertex4.Position = new Point2D<int>(2, 2, "San Francisco");
            graphVertex5.Position = new Point2D<int>(5, 5, "Orlando");
            graphVertex6.Position = new Point2D<int>(-2, 8, "Las Vegas");

            GraphEdgeInfo graphEdgeInfo12 = new GraphEdgeInfo("Chicago - Dallas", graphVertex1.Position, graphVertex2.Position, 1);
            GraphEdgeInfo graphEdgeInfo13 = new GraphEdgeInfo("Chicago - Atlanta", graphVertex1.Position, graphVertex3.Position, 1);

            GraphEdgeInfo graphEdgeInfo21 = new GraphEdgeInfo("Dallas - Chicago", graphVertex2.Position, graphVertex1.Position, 1);
            GraphEdgeInfo graphEdgeInfo24 = new GraphEdgeInfo("Dallas - San Francisco", graphVertex2.Position, graphVertex4.Position, 1);

            GraphEdgeInfo graphEdgeInfo31 = new GraphEdgeInfo("Atlanta - Chicago", graphVertex3.Position, graphVertex1.Position, 1);
            GraphEdgeInfo graphEdgeInfo35 = new GraphEdgeInfo("Atlanta - Orlando", graphVertex3.Position, graphVertex5.Position, 1);

            GraphEdgeInfo graphEdgeInfo42 = new GraphEdgeInfo("San Francisco - Dallas", graphVertex4.Position, graphVertex2.Position, 1);
            GraphEdgeInfo graphEdgeInfo45 = new GraphEdgeInfo("San Francisco - Orlando", graphVertex4.Position, graphVertex5.Position, 1);
            GraphEdgeInfo graphEdgeInfo46 = new GraphEdgeInfo("San Francisco - Las Vegas", graphVertex4.Position, graphVertex6.Position, 1);

            GraphEdgeInfo graphEdgeInfo53 = new GraphEdgeInfo("Orlando - Atlanta", graphVertex5.Position, graphVertex3.Position, 1);
            GraphEdgeInfo graphEdgeInfo54 = new GraphEdgeInfo("Orlando - San Francisco", graphVertex5.Position, graphVertex4.Position, 1);
            GraphEdgeInfo graphEdgeInfo56 = new GraphEdgeInfo("Orlando - Las Vegas", graphVertex5.Position, graphVertex6.Position, 1);

            GraphEdgeInfo graphEdgeInfo64 = new GraphEdgeInfo("Las Vegas - San Francisco", graphVertex6.Position, graphVertex4.Position, 1);
            GraphEdgeInfo graphEdgeInfo65 = new GraphEdgeInfo("Las Vegas - Orlando", graphVertex6.Position, graphVertex5.Position, 1);

            graphVertex1.AddEdge(graphEdgeInfo12);
            graphVertex1.AddEdge(graphEdgeInfo13);

            graphVertex2.AddEdge(graphEdgeInfo21);
            graphVertex2.AddEdge(graphEdgeInfo24);

            graphVertex3.AddEdge(graphEdgeInfo31);
            graphVertex3.AddEdge(graphEdgeInfo35);

            graphVertex4.AddEdge(graphEdgeInfo42);
            graphVertex4.AddEdge(graphEdgeInfo45);
            graphVertex4.AddEdge(graphEdgeInfo46);
            

            graphVertex5.AddEdge(graphEdgeInfo53);
            graphVertex5.AddEdge(graphEdgeInfo54);
            graphVertex5.AddEdge(graphEdgeInfo56);

            graphVertex6.AddEdge(graphEdgeInfo64);
            graphVertex6.AddEdge(graphEdgeInfo65);

            _graphInfo.AddVertex(graphVertex1);
            _graphInfo.AddVertex(graphVertex2);
            _graphInfo.AddVertex(graphVertex3);
            _graphInfo.AddVertex(graphVertex4);
            _graphInfo.AddVertex(graphVertex5);
            _graphInfo.AddVertex(graphVertex6);
        }

        [TestMethod]
        public void DFSRecursive()
        {
            //============= Graphs =============
            //Chicago Dallas San Francisco Orlando Atlanta Las Vegas
            //Chicago Atlanta Orlando Las Vegas San Francisco Dallas
            //Chicago Dallas Atlanta San Francisco Orlando Las Vegas
            var expectedResult = new List<string>() { "Chicago", "Dallas", "San Francisco", "Orlando", "Atlanta", "Las Vegas" };

            SearchDepth searchDepth = new SearchDepth(_graphInfo);

            var startVertex = _graphInfo.GraphVertexInfos.FirstOrDefault(x => x.Name == expectedResult[0]);

            var result = searchDepth.DFSRecursive(startVertex);

            Assert.IsNotNull(result);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }

        [TestMethod]
        public void DFSIterative()
        {
            var expectedResult = new List<string>() { "Chicago", "Atlanta", "Orlando", "Las Vegas", "San Francisco", "Dallas" };

            SearchDepth searchDepth = new SearchDepth(_graphInfo);

            var startVertex = _graphInfo.GraphVertexInfos.FirstOrDefault(x => x.Name == expectedResult[0]);

            var result = searchDepth.DFSIterative(startVertex);

            Assert.IsNotNull(result);
            CollectionAssert.AreEquivalent(expectedResult, result);
        }
    }
}