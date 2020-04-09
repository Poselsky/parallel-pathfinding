using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    static class AStarGridAlgorithm
    {
        static public Node[] CalculateShortestPath(GridNode From, GridNode To, NodeMap Map)
        {
            throw new NotImplementedException();
        }

        static private double CalculateH(GridNode From, GridNode To)
        {
            int[] fromxy = From.GetXY();
            int[] toxy = To.GetXY();

            double length = Math.Sqrt(Math.Pow(fromxy[0] - toxy[0], 2) + Math.Pow(fromxy[1] - toxy[1], 2)); //sqrt(a^2 + b^2) --> length of a line between two points

            return length;
        }
    }
}
