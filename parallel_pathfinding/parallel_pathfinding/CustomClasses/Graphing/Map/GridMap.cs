using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    public class GridMap : NodeMap
    {
        public GridMap(Func<GridNode, GridNode, NodeMap, Node[]> PathfindingAlgorithm) 
            : base(new Func<Node, Node, NodeMap, Node[]>((From, To, Map) => PathfindingAlgorithm((GridNode)From, (GridNode)To, Map))) { }

        public override void GenerateMap(int Width, int Height)
        {
            MatrixMapRepresentation = new Node[Width, Height];
            // Generate Empty Nodes
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    MatrixMapRepresentation[i, j] = new GridNode(i,j);
                }
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        // X O O O O
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        SetRight(i,j);
                        SetBottomRight(i,j);
                        SetBottom(i, j);
                    }
                    else if (i == Width - 1 && j == 0)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // X O O O O
                        SetTop(i, j);
                        SetTopRight(i, j);
                        SetRight(i, j);
                    }
                    else if (i == Width - 1 && j == Height - 1)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // O O O O X
                        SetTop(i, j);
                        SetLeft(i, j);
                        SetTopLeft(i, j);
                    }
                    else if (i == 0 && j == Height - 1)
                    {
                        // O O O O X
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        SetBottom(i, j);
                        SetBottomLeft(i, j);
                        SetLeft(i, j);
                    }
                    else if (j == 0)
                    {
                        // O O O O O
                        // X O O O O
                        // X O O O O
                        // O O O O O
                        SetTop(i, j);
                        SetTopRight(i, j);
                        SetRight(i, j);
                        SetBottomRight(i, j);
                        SetBottom(i, j);
                    }
                    else if (j == Height - 1)
                    {
                        // O O O O O
                        // O O O O X
                        // O O O O X
                        // O O O O O
                        SetTop(i, j);
                        SetTopLeft(i, j);
                        SetLeft(i, j);
                        SetBottomLeft(i, j);
                        SetBottom(i, j);
                    }
                    else if (i == Width - 1)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // O X X X O
                        SetLeft(i, j);
                        SetTopLeft(i, j);
                        SetTop(i, j);
                        SetTopRight(i, j);
                        SetRight(i, j);
                    }
                    else if (i == 0)
                    {
                        // O X X X O
                        // O O O O 0
                        // O O O O 0
                        // O O O O O
                        SetLeft(i, j);
                        SetBottomLeft(i, j);
                        SetBottom(i, j);
                        SetBottomRight(i, j);
                        SetRight(i, j);
                    }
                    else
                    {
                        // O O O O O
                        // O X X X O
                        // O X X X O
                        // O O O O O
                        SetTop(i, j);
                        SetTopRight(i, j);
                        SetRight(i, j);
                        SetBottomRight(i, j);
                        SetBottom(i, j);
                        SetBottomLeft(i, j);
                        SetLeft(i, j);
                        SetTopLeft(i, j);
                    }
                }
            }
        }

        private void SetTop(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x - 1, y], 1);
        }

        private void SetTopRight(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x - 1, y + 1], 1.4);
        }

        private void SetRight(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x, y + 1], 1);
        }

        private void SetBottomRight(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x + 1, y + 1], 1.4);
        }
        private void SetBottom(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x + 1, y], 1);
        }

        private void SetBottomLeft(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x + 1, y - 1], 1.4);
        }

        private void SetLeft(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x, y - 1], 1);
        }
        private void SetTopLeft(int x, int y)
        {
            MatrixMapRepresentation[x, y].AddNeighbour(MatrixMapRepresentation[x - 1, y - 1], 1.4);
        }

        public override Node[] GetShortestPath(Node A, Node B)
        {
            return this.PathFindWithMap(A, B, this);
        }

        public new GridNode this[int x, int y] => (GridNode)MatrixMapRepresentation[x, y];
    }
}
