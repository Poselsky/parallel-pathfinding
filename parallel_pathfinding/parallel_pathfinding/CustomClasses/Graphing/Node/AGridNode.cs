using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class AGridNode : GridNode
    {
        private double hCost;
        private double fCost;

        public AGridNode(int PositionX, int PositionY) : base(PositionX, PositionY)
        {}

        public void SetGHCost(double gCost, double hCost)
        {
            this.gCost = gCost;
            this.hCost = hCost;
            this.fCost = this.gCost + this.hCost;
        }

        public double GetHCost()
        { return hCost; }
        public double GetFCost()
        { return fCost; }
    }
}
