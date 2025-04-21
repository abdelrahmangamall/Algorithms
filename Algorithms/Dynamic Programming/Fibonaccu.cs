using Algorithms.helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming
{
    class Fibonaccu : ParentForAllAlgorithms
    {

        public int FibWithTopDown(int n)
        {
            int[] arr = new int[n + 1];

            if (arr[n] != 0) return arr[n];
            else if (n <= 1) return arr[n] = 1;

            else
            {
                arr[n] = FibWithTopDown(n - 1) + FibWithTopDown(n - 2);
                return arr[n];
            }
        }
        
        
        
        
        public int[] FibWithButtomUp(int n)
        {
            int[] arr = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)  arr[i] = 1;
                else  arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr;
        }
    }
    
}

