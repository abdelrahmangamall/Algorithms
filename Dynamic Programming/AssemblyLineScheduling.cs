using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    public class AssemblyLineScheduling
    {
        static int[,] a = 
        {
         { 4, 5, 3, 2 }, // line 0
         { 2, 10, 1, 4 } // line 1
        };

        static int[,] t = 
        {
         { 0, 7, 4, 0 },    // from line 0 to 1
         { 0, 9, 2, 0 }     // from line 1 to 0
        };

        static int[] e = { 10, 12 };
        public int[] x = { 18, 7 };

        public int[,] dp;
        public int MinTime(int n, int l) 
        {
            if (dp[n, l] != -1)
                return dp[n, l];

            if (n == 0)
                return dp[n, l] = a[l, 0] + e[l];

            int otherLine = l == 0 ? 1 : 0;

            int SameLine = MinTime(n - 1, 0);
            int SwitchLine = MinTime(n - 1, otherLine) + t[otherLine, n - 1];
            
                dp[n, l] = Math.Min(SameLine, SwitchLine) + a[l,n];
            return dp[n, l];
        
        }

    }
}
