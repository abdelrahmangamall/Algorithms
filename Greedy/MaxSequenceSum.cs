using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Greedy
{
    public class MaxSequenceSum
    {
        int currSum = 0;
        int maxSum = 0;
        public int MaxSeqSum(int[] arr) 
        {
            int len = arr.Length;

          for (int i = 0; i < len; i++) 
          {
            currSum += arr[i];
            currSum = Math.Max(0, currSum);
                
                maxSum = Math.Max(maxSum, currSum);     
          }
               return maxSum;
        }
    }
}
