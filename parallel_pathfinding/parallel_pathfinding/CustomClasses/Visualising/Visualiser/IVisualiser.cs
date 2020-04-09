using System;
using System.Collections.Generic;
using System.Text;
using parallel_pathfinding.CustomClasses.Graphing;

namespace parallel_pathfinding.CustomClasses.Visualising
{
    interface IVisualiser
    {
        public void Visualise(NodeMap Map);
    }
}
