using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    abstract class NodeMap
    {
        private Func<Node, Node, double> PathFind;
        private Node[,] MatrixMapRepresentation;
        public NodeMap (IPathFindingAlgorithm Algorithm)
        {
            this.PathFind = new Func<Node, Node, double>(Algorithm.CalculateShortestPath);
        }

        abstract public void GenerateMap(int Width, int Height);
        abstract public double GetShortestPath(Node A, Node B);
    }
}
