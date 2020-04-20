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

        [Test]
        public void GetShortestPath_3By3Grid_SuccesIfIsPathFromBottomLeftAndTopRightCorner()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(3, 3);
            var GeneratedShortestPath = s.GetShortestPath(s[2, 0], s[0, 2]);
            var TrueShortestPath = new Node[] { s[2, 0], s[1,1], s[0, 2] };
            for (int i = 0; i < TrueShortestPath.Length; i++)
            {
                if (TrueShortestPath[i] != GeneratedShortestPath[i])
                {
                    Assert.Fail("Shortest paths are not same. Check if order of nodes in path is correct.");
                }
            }

            Assert.Pass();
        }

        [Test]
        public void GetShortestPath_3By3Grid_SuccesIfIsPathFromTopLeftAndBottomRightCorner()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(3, 3);
            var GeneratedShortestPath = s.GetShortestPath(s[0, 0], s[2, 2]);
            var TrueShortestPath = new Node[] { s[0, 0], s[1, 1], s[2, 2] };
            for (int i = 0; i < TrueShortestPath.Length; i++)
            {
                if (TrueShortestPath[i] != GeneratedShortestPath[i])
                {
                    Assert.Fail("Shortest paths are not same. Check if order of nodes in path is correct.");
                }
            }

            Assert.Pass();
        }

        [Test]
        public void GetShortestPath_1Point_FailsIfIsNotTheSamePoint()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(1, 1);
            var GeneratedShortestPath = s.GetShortestPath(s[0, 0], s[0, 0]);
            var TrueShortestPath = new Node[] { s[0, 0] };

            Assert.That(GeneratedShortestPath[0] == TrueShortestPath[0], "Method doesn't return the same point");
        }

        [Test]
        public void GetShortestPath_200By200Grid_SuccesIfIsPathFromTopLeftAndBottomRightCorner()
        {
            var s = new GridMap(new Func<GridNode, GridNode, NodeMap, Node[]>(AStarGridMapAlghoritm.FindShortestPathSingleThread));

            s.GenerateMap(200, 200);
            var GeneratedShortestPath = s.GetShortestPath(s[0, 0], s[199, 199]);
            var TrueShortestPath = new Node[1000] ;

            for(int i = 0; i < 200; i++)
            {
                TrueShortestPath[i] = s[i, i];
            }

            for (int i = 0; i < TrueShortestPath.Length; i++)
            {
                if (TrueShortestPath[i] != GeneratedShortestPath[i])
                {
                    Assert.Fail("Shortest paths are not same. Check if order of nodes in path is correct.");
                }
            }

            Assert.Pass();
        }
    }

}
