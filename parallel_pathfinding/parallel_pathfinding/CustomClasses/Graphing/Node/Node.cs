using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class Node
    {
        private double _gCost = 0; //current lenght from starting Node, starting Node has g = 0
        private double _hCost = 0;

        public Node()
        { }

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
