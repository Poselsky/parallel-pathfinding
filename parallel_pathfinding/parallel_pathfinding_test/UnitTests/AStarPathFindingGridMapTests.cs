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
        public void GetShortestPath_2By2Grid_SuccesIfIsPathFromBottomLeftAndTopRightCorner()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(2, 2);
            var GeneratedShortestPath = s.GetShortestPath(s[1, 0], s[0, 1]);
            var TrueShortestPath = new Node[] { s[1, 0], s[0, 1] };
            for(int i = 0; i < TrueShortestPath.Length; i++)
            {
                if(TrueShortestPath[i] != GeneratedShortestPath[i])
                {
                    Assert.Fail("Shortest paths are not same. Check if order of nodes in path is correct.");
                }
            }

            Assert.Pass();
        }

        [Test]
        public void GetShortestPath_10By1Grid_FailIfLengthOfPathIsNot10()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(1, 10);

            var GeneratedPath = s.GetShortestPath(s[0, 0], s[0, 9]);

            Assert.IsTrue(GeneratedPath.Length == 10);
        }
    }

}
