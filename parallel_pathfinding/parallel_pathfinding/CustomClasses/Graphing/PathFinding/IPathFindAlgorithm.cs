using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    interface IPathFindingAlgorithm
    {
        public Node[] CalculateShortestPath(Node From, Node To);
    }
}
