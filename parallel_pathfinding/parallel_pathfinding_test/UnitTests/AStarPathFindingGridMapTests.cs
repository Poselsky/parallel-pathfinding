using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using parallel_pathfinding.CustomClasses.Graphing;

namespace parallel_pathfinding_test.UnitTests.PathFinding
{
    [TestFixture]
    public class AStarPathFindingGridMapTests
    {
        [Test]
        public void GetShortestPath_2By2Grid_SuccesIfIsPathFromBottomLeftAndTopRightCorner ()
        {
            var s = new GridMap(new Func<Node, Node, NodeMap, Node[]>((a, b, c) => new Node[1]));

            s.GenerateMap(5, 5);
        }
    }

}
