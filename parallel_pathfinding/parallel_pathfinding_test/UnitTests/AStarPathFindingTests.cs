﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using parallel_pathfinding.CustomClasses.Graphing;

namespace parallel_pathfinding_test.UnitTests.PathFinding
{
    [TestFixture]
    public class AStarPathFindingTests
    {
        [Test]
        public void GetShortestPath_2By2Grid_ReturnsPathFromBottomLeftAndTopRightCorner ()
        {
            var s = new Map(new Func<Node, Node, NodeMap, Node[]>((a, b, c) => new Node[1]));

            s.GenerateMap(5, 5);
        }
    }

    class Map : NodeMap
    {
        public Map(Func<Node, Node,NodeMap, Node[]> PathfindingAlgorithm) : base(PathfindingAlgorithm) { }

        public override void GenerateMap(int Width, int Height)
        {
            MatrixMapRepresentation = new Node[Width, Height];
            // Generate Empty Nodes
            for (int i = 0; i < Width; i++)
            {
                for(int j = 0; j < Height; j++)
                {
                    MatrixMapRepresentation[i, j] = new Node();
                }
            }

            for (int i = 0; i < Width; i++)
            {
                for (int j = 1; j < Height; j++)
                {
                    if (i == 0)
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
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, 1], j + 1);
                        // Bottom Right
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, 1], j + 1);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j + 1], 1);
                    } else if (i == Width - 1)
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
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], j);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], j);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);
                    } else if (j == 0)
                    {
                        // O X X X O
                        // O O O O 0
                        // O O O O 0
                        // O O O O O
                        // Top
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j], 1);
                        // Top Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i - 1, j - 1], 1);
                        // Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i, j - 1], j);
                        // Bottom Left
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j - 1], j);
                        // Bottom
                        MatrixMapRepresentation[i, j].AddNeighbour(MatrixMapRepresentation[i + 1, j], 1);

                    } else if (j == Height - 1)
                    {

                    } else
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
