using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForce
{
    class ManufactureMachines
    {

        public int MaxNumOfMachines(int[] x, int[] y) 
        {
            int len = x.Length;
            int i = 0;
            int R=0, C=0, D =0;
            if (x[i] >= 1)
                R = y[i] / x[i];
            i++;
            if (x[i] >= 1)
               C = y[i] / x[i];
            i++;
            if (x[i] >= 1)
                D = y[i] / x[i];
            int max = Math.Min(R, Math.Min(C, D));
            return max;
        }
    }
}
