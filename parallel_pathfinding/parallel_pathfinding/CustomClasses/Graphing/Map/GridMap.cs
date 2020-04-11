using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Graphing
{
    class GridMap : NodeMap
    {
        public GridMap(Func<Node, Node, NodeMap, Node[]> PathfindingAlgorithm) : base(PathfindingAlgorithm) { }

        public override void GenerateMap(int Width, int Height)
        {
            MatrixMapRepresentation = new Node[Width, Height];
            // Generate Empty Nodes
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    MatrixMapRepresentation[i, j] = new Node();
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
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j + 1], 1);
                        // Bottom Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j + 1], 1);
                        // Bottom
                    }
                    else if (i == Width - 1 && j == 0)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // X O O O O
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j + 1], 1);
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j + 1], 1);
                    }
                    else if (i == Width - 1 && j == Height - 1)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // O O O O X
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                        // Top Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j - 1], 1);
                    }
                    else if (i == 0 && j == Height - 1)
                    {
                        // O O O O X
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], 1);
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                    }
                    else if (j == 0)
                    {
                        // O O O O O
                        // X O O O O
                        // X O O O O
                        // O O O O O
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j + 1], 1);
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, 1], 1);
                        // Bottom Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, 1], 1);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j + 1], 1);
                    }
                    else if (j == Height - 1)
                    {
                        // O O O O O
                        // O O O O X
                        // O O O O X
                        // O O O O O
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j - 1], 1);
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], 1);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);
                    }
                    else if (i == Width - 1)
                    {
                        // O O O O O
                        // O O O O O
                        // O O O O O
                        // O X X X O
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                        // Top Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j - 1], 1);
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j + 1], 1);
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j + 1], 1);
                    }
                    else if (i == 0)
                    {
                        // O X X X O
                        // O O O O 0
                        // O O O O 0
                        // O O O O O
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], 1);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);
                        // Bottom Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j + 1], 1);
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j + 1], 1);

                    }
                    else
                    {
                        // O O O O O
                        // O X X X O
                        // O X X X O
                        // O O O O O
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j + 1], 1);
                        // Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j + 1], 1);
                        // Bottom Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j + 1], 1);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], 1);
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], 1);
                        // Top Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j - 1], 1);
                    }
                }
            }
        }

        public override Node[] GetShortestPath(Node A, Node B)
        {
            throw new NotImplementedException();
        }
    }
}
