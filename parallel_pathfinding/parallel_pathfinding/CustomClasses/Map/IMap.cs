using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    interface IMap
    {
        void GenerateMap(int Width, int Height);
        void GetShortestPath(Node A, Node B);

    }
}
