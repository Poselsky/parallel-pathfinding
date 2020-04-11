using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class GridNode : Node
    {
        public Tuple<int, int> Coordinates { get; private set; }
        public GridNode(int CoordinateX, int CoordinateY)
        {
            Coordinates = new Tuple<int, int>(CoordinateX, CoordinateY);
        }
    }
}
