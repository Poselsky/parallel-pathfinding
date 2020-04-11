using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    abstract class NodeMap
    {
        protected Func<Node, Node, Node[]> PathFindMapless;
        protected Func<Node, Node, NodeMap, Node[]> PathFindWithMap;
        public Node[,] MatrixMapRepresentation { get; protected set; }
        public NodeMap (Func<Node, Node, Node[]> PathfindingAlgorithm)
        {
            this.PathFindMapless = PathfindingAlgorithm;
        }

        public NodeMap(Func<Node, Node, NodeMap, Node[]> PathfindingAlgorithm)
        {
            this.PathFindWithMap = PathfindingAlgorithm;
        }

        abstract public void GenerateMap(int Width, int Height);
        abstract public Node[] GetShortestPath(Node A, Node B);

        public Node this[int i, int j]
        {
            get => MatrixMapRepresentation[i, j];
        }
    }
}
