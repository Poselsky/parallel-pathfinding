using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class GridNode : Node
    {
        public GridNode Parent { get; set; }
        public int PositionX { get; }
        public int PositionY { get; }
        public bool IsWall { get; private set; } = false;

        private double GCost { get; set; } = 0; //current lenght from starting Node, starting Node has g = 0
        public double HCost { get; set; } = 0;

        public GridNode(int PositionX, int PositionY) : base()
        {
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }

        public void MakeWall()
        {
            IsWall = true;
        }

        public void UnmakeWall()
        {
            IsWall = false;
        }

        public double FCost() => GCost + HCost; 
    }
}
