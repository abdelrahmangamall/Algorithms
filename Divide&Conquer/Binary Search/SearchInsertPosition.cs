using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int r = nums.Length-1;
            int l = 0;
            
            while (l <= r) 
            {
                int mid = l + (r - l) / 2;
                
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                {
                    r = mid - 1;
                }
                else if (nums[mid]<target) 
                {
                    l = mid + 1;
                }
            }
            return l;
        }
    }
}
