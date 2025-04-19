using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class AssemblyLineScheduling
    {
        static int[,] a = {
        { 4, 5, 3, 2 }, // line 0
        { 2, 10, 1, 4 } // line 1
    };

        static int[,] t = {
        { 0, 7, 4 },    // from line 0 to 1
        { 0, 9, 2 }     // from line 1 to 0
    };

        static int[] e = { 10, 12 };
        public int[] x = { 18, 7 };

        static int[,] dp;
        public int MinTime(int n, int l) 
        {
            dp = new int[n+1, 2];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < 2; j++)
                    dp[i, j] = -1;

            if (dp[n, l] != -1)
                return dp[n, l];



            if (n == 0)
                return dp[n, l] = a[l, 0] + e[l];

            int otherLine = l == 0 ? 1 : 0;



            int SameLine = MinTime(n - 1, 1) + a[l,n];
            int SwitchLine = MinTime(n - 1, otherLine) + t[otherLine, n - 1] + a[l, n];

            dp[n, l] = Math.Min(SameLine, SwitchLine);
            return dp[n, l];
        
        }

    }
}
