using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class AStarGridMapAlghoritm
    {
        private AStarGridMapAlghoritm() { }

        public static Node[] FindShortestPathSingleThread(GridNode From, GridNode To, NodeMap Map)
        {
            List<GridNode> open = new List<GridNode>(); // Nodes yet to be evaluated, at first only start node will be here
            List<GridNode> closed = new List<GridNode>(); // Nodes already evaluated

            List<Node> finalList = new List<Node>();


            GridNode current = From;
            current.HCost = CalculateH(current, To);
            current.GCost = 0;

            open.Add(current);

            while (current != To)
            {
                current = open[0];
                foreach (GridNode node in open)
                {
                    if (node.FCost() <= current.FCost())
                        if (node.HCost < current.HCost)
                            current = node;
                }
                open.Remove(current);
                closed.Add(current);

                if (current == To)
                    break;

                foreach (var neighbour in current.Neighbours)
                {
                    GridNode typeCastedNeighbour = (GridNode)neighbour.Item1;
                    if (closed.Contains(typeCastedNeighbour))
                    { 
                        continue; 
                    }
                    if (open.Contains(typeCastedNeighbour))
                    {
                        if (typeCastedNeighbour.FCost() >= (current.GCost + neighbour.Item2 + typeCastedNeighbour.HCost))
                            continue;
                    }
                    else
                        open.Add(typeCastedNeighbour);

                    typeCastedNeighbour.HCost = CalculateH(typeCastedNeighbour, To);
                    typeCastedNeighbour.GCost = current.GCost + neighbour.Item2;
                    typeCastedNeighbour.Parent = current;
                }
            }

            while (current != From)
            {
                finalList.Add(current);
                current = current.Parent;
            }
            finalList.Add(current);

            finalList.Reverse();
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


        //sqrt(a^2 + b^2) --> length of a line between two points
        static private double CalculateH(GridNode From, GridNode To) => Math.Sqrt(Math.Pow((double)From.PositionX - (double)To.PositionX, 2) + Math.Pow((double)From.PositionY - (double)To.PositionY, 2));
    }
}
