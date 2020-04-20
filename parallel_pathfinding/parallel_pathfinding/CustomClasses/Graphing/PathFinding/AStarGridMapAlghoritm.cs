using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class AStarGridMapAlghoritm
    {
        private AStarGridMapAlghoritm() { }

        public static Node[] FindShortestPathSingleThread (GridNode From, GridNode To, NodeMap Map)
        {
            List<GridNode> open = new List<GridNode>(); // Nodes yet to be evaluated, at first only start node will be here
            List<GridNode> closed = new List<GridNode>(); // Nodes already evaluated

            List<Node> finalList = new List<Node>();


            GridNode current = From;
            current.SetHCost(CalculateH(current, To));
            current.SetGCost(0);

            open.Add(current);

            while (current != To)
            {
                current = open[0];
                foreach (GridNode node in open)
                {
                    if (node.GetFCost() <= current.GetFCost())
                        if (node.GetHCost() < current.GetHCost())
                            current = node;
                }
                open.Remove(current);
                closed.Add(current);

                if (current == To)
                    break;

                foreach (var neighbour in current.Neighbours)
                {
                    if (neighbour.Item1.IsWall() | closed.Contains(neighbour.Item1))
                    { continue; }
                    if (open.Contains(neighbour.Item1))
                    {
                        if (neighbour.Item1.GetFCost() >= (current.GetGCost() + neighbour.Item2 + neighbour.Item1.GetHCost()))
                        { continue; }
                    }
                    else
                        open.Add(neighbour.Item1);

                    neighbour.Item1.SetHCost(CalculateH(current, To));
                    neighbour.Item1.SetGCost(current.GetGCost() + neighbour.Item2);
                    neighbour.Item1.SetParent(current);
                }
            }

            finalList.Add(From);
            while (current != From)
            {
                finalList.Add(current);
                current = current.GetParent();
            }

            return finalList.ToArray();
        }

        public static Node[] FindShortestPathInParallel(GridNode From, GridNode To, NodeMap Map)
        {
            throw new NotImplementedException("Pathfinding to be Implemented");
        }

        public static Node[] FindShortestPathWithSplittingThreads(GridNode From, GridNode To, NodeMap Map)
        {
            throw new NotImplementedException("Pathfinding to be Implemented");
        }

        static private double CalculateH(GridNode From, GridNode To)
        {
            int[] fromXY = From.GetXY();
            int[] toXY = To.GetXY();

            double length = Math.Sqrt(Math.Pow(fromXY[0] - toXY[0], 2) + Math.Pow(fromXY[1] - toXY[1], 2)); //sqrt(a^2 + b^2) --> length of a line between two points

            return length;
        }
    }
}
