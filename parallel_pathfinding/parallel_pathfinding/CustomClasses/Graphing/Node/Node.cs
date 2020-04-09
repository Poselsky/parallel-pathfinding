using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class Node
    {
        public List<Tuple<Node, double>> Neighbours { get; }

        public Node()
        {
            this.Neighbours = new List<Tuple<Node, double>>();
        }

        public void AddNeighbour(Node Neighbour, double Distance)
        {
            Neighbours.Add(new Tuple<Node, double>(Neighbour, Distance));
        }
    }
}
