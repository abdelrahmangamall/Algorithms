using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class EditDistance
    {
        public string s1;
        public string s2;
       
        public int ED_BF_Recursion(int n ,int m)
        {
            if (n == 0) return m; //Insertions

            if (m == 0) return n; //Deletions


            if (s1[n-1] == s2[m-1]) return ED_BF_Recursion(n - 1, m - 1);
            else 
            {
                int add = ED_BF_Recursion(n, m - 1);
                int replace = ED_BF_Recursion(n - 1, m);
                int delete = ED_BF_Recursion(n - 1, m - 1);

                
                int min = Math.Min( delete, Math.Min(add, replace)) + 1;
                return min;
            }
        }
        public int ED_DP_ButtomUp(string x ,string y) 
        {

            int n = x.Length;
            int m = y.Length;

            int[,] dp = new int[n + 1, m + 1];

            for(int i = 0;i<= n ; i++)
            {
                for (int j = 0; j <= m; j++) 
                {
                    if (i == 0) dp[i, j] = j;

                    else if (j == 0) dp[i, j] = i;
                    
                    else if (x[i - 1] == y[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else 
                    {
                        dp[i, j] = 1 +
                                       Math.Min(dp[i, j - 1],
                                   Math.Min(dp[i - 1, j - 1],
                                              dp[i - 1, j]));
                    
                    }
                }
            }
            return dp[n, m];
          
        }
    }
}
