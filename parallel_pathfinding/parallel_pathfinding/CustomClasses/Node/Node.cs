using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class Node
    {
        public List<Node> Neighbours { get; }

        public Node()
        {
            this.Neighbours = new List<Node>();
        }

        public void AddNeighbour(Node Neighbour)
        {
            Neighbours.Add(Neighbour);
        }
    }
}
