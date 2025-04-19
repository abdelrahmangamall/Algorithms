using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class AssemblyLineScheduling
    {
        // Number of stations (stages) per line
        public int N;

        // a[i, j]: Time taken at stage j on line i
        public int[,] a;

        // e[i]: Entrance time for line i
        public int[] e;

        // x[i]: Exit time for line i
        public int[] x;

        // t[i, j]: Time to transfer from line i at stage j to stage j+1 on the other line
        public int[,] t;


    }
}
