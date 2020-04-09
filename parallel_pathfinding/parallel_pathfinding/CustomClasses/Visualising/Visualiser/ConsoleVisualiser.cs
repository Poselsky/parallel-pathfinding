using parallel_pathfinding.CustomClasses.Graphing;
using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_pathfinding.CustomClasses.Visualising
{
    class ConsoleVisualiser : IVisualiser
    {
        public void Visualise(NodeMap Map, Node[] Path)
        {

            int pathIndex = 0;
            for(int i = 0; i < Map.MatrixMapRepresentation.GetLength(0); i++)
            {
                for (int j = 0; j < Map.MatrixMapRepresentation.GetLength(1); j++)
                {
                    bool areSame = Map[i, j] == Path[pathIndex];
                    if (areSame && Path.Length - pathIndex > 0)
                    {
                        pathIndex++;
                    }

                    Console.Write(GetNodeCharRepresentation(Map[i, j],areSame) + " ");
                }
                Console.WriteLine("\r\n");
            }
        }

        private char GetNodeCharRepresentation(Node Input, bool IsPartOfPath)
        {
            if (Input == null)
            {
                return '-';
            } else if (IsPartOfPath)
            {
                return 'X';
            } else
            {
                return 'O';
            }
        }
    }
}
