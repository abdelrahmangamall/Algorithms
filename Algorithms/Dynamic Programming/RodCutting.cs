using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class RodCutting
    {
        int[] prices = {0,3,5,8,9,10,17,17,20,24,30}; 

        public int CR_Recursion(int n) 
        {

            if (n == 0)
                return 0;
           
            int m = 0;

            for (int i = 1; i <= n; i++) 
                m = Math.Max(m, CR_Recursion(n - i) + prices[i]);

            return m;
        }

        public int CR_Recursive(int n) 
        {
            int[] R = new int[n+1];

                for (int k = 0; k <= n; k++)
                {
                  if (k == 0) R[k] = 0;
                  else 
                  {
                    int m = 0;
                    for (int i = 1; i <= k; i++)
                    {
                        m = Math.Max(m, prices[i] + R[k - i]);
                       R[k] = m;
                    }

                  }
                }
            return R[n];
            
        }
    }
}
