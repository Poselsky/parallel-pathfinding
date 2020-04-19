using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class GridNode : Node
    {
        private Tuple<int, int> Position;
        public GridNode parent{get; set;}
        public GridNode(int PositionX, int PositionY) : base()
        {
            this.Position = new Tuple<int, int>(PositionX, PositionY);
        }

        public int[] GetXY()
        {
            int[] coordinates = new int[2];
            coordinates[0] = Position.Item1;
            coordinates[1] = Position.Item2;
            return coordinates;
        }

    }
}
