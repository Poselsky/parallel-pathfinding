using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class GridNode : Node
    {
        private bool _isWall = false;
        public List<Tuple<GridNode, double>> Neighbours { get; }
        private GridNode _parent;
        private Tuple<int, int> Position;

        public GridNode(int PositionX, int PositionY) : base()
        {
            this.Neighbours = new List<Tuple<GridNode, double>>();
            this.Position = new Tuple<int, int>(PositionX, PositionY);
        }

        public void AddNeighbour(GridNode Neighbour, double Distance)
        {
            Neighbours.Add(new Tuple<GridNode, double>(Neighbour, Distance));
        }

        public int[] GetXY()
        {
            int[] coordinates = new int[2];
            coordinates[0] = Position.Item1;
            coordinates[1] = Position.Item2;
            return coordinates;
        }

        public GridNode GetParent()
        { return _parent; }

        public void SetParent(GridNode parent)
        { _parent = parent; }

        public void MakeWall()
        {
            _isWall = true;
        }

        public void UnmakeWall()
        {
            _isWall = false;
        }

        public bool IsWall()
        {
            return _isWall;
        }


    }
    /*
    public class GridNode : Node
    {
        public Tuple<int, int> Coordinates { get; private set; }
        public GridNode(int CoordinateX, int CoordinateY)
        {
            Coordinates = new Tuple<int, int>(CoordinateX, CoordinateY);
        }
    }
    */
}
