using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class Node
    {
        public List<Tuple<Node, double>> Neighbours { get; }
        private double _gCost; //current lenght from starting Node, starting Node has g = 0
        private double _hCost;

        public Node()
        {
            this.Neighbours = new List<Tuple<Node, double>>();
        }

        public void AddNeighbour(Node Neighbour, double Distance)
        {
            Neighbours.Add(new Tuple<Node, double>(Neighbour, Distance));
        }

        public void SetGCost(double gCost)
        {
            _gCost = gCost;
        }

        public void SetHCost(double hCost)
        { _hCost = hCost; }

        public double GetGCost()
        {
            return _gCost;
        }

        public double GetHCost()
        { return _hCost; }
        public double GetFCost()
        { return _hCost + _gCost; }
    }
}
