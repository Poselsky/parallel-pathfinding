﻿using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class GridNode : Node
    {
        private Tuple<int, int> Position;
        public GridNode(int PositionX, int PositionY) : base()
        {
            this.Position = new Tuple<int, int>(PositionX, PositionY);
        }

        public int[] GetXY()
        {
            int[] coordinates = [Position.Item1, Position.Item2];
            return coordinates;
        }

    }
}
