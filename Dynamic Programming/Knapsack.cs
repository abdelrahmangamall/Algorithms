using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class Knapsack
    {
       public int[] w = new int[] {10,5,10,15 };
       public int[] v = new int[] {20,15,10,10 };
        public int kS_BruteForce(int W, int n) 
        {

            if (W == 0 || n == 0) return 0;

            else if (w[n-1] > W) return kS_BruteForce(W, n - 1);

            else return Math.Max(kS_BruteForce(W - w[n-1], n - 1) + v[n-1], kS_BruteForce(W, n - 1));
        }

        public int[,] dp;
        public int max = 0;
        public int KS_DP_TopDown(int W, int n) 
        {
            

                    if (W == 0 || n == 0) dp[W, n] = 0;

                    else if (dp[W, n] != -1) return dp[W, n];

                    else if (w[n-1] > W)
                    {
                       max = KS_DP_TopDown(W, n - 1);
                       dp[W, n] = max;
                    }

            else 
            {
                        max = Math.Max(KS_DP_TopDown(W - w[n-1], n- 1) + v[n- 1], KS_DP_TopDown(W, n-1));
                       dp[W, n] = max;

            }




            return dp[W, n];

        }
    }
}
