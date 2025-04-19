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

        public int FibWithTopDown(int num)
        {
            int[] nums = new int[num+1];


            if (nums[num] != 0) return nums[num];

            if (num<= 1) return nums[num] = 1;

            nums[num] = FibWithTopDown(num - 1) + FibWithTopDown(num - 2);
            return nums[num];
        }
        
        
        
        
        
        public int[] FibWithButtomUp(int num)
        {
            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
            {
                if (i <= 1) nums[i] = 1;
                else nums[i] = nums[i - 1] + nums[i - 2];
            }
            return nums;
        }
    }
}

