using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DivideAndConquer
{
    class MergeSort : ParentForAllAlgorithms
    {
        public void Sort(int[] nums,int l,int r) 
        {
            if(l<r)
            {
                int m = l+ (r-l)/2;
                Sort(nums, l, m);
                Sort(nums, m + 1, r);

                Merge(nums, m, l, r);
             
            }
        }


      

        private void Merge(int[] nums, int m, int l, int r)
        {
            int i, j, k;

            int sizeArr1 = m - l+1;
            int sizeArr2 = r - m;

            int[] arr1 = new int[sizeArr1];
            int[] arr2 = new int[sizeArr2];
            for (i = 0; i < sizeArr1; i++) 
            {
                arr1[i] = nums[i + l];
            }
            for (j = 0; j < sizeArr2; j++) 
            {
                arr2[j] = nums[m + j+1];
            }
            i = j = 0;
            k = l;
            while (i<sizeArr1&&j<sizeArr2) 
            {
                if (arr1[i] >= arr2[j])
                {
                    nums[k] = arr2[j];
                    j++;
                }
                else 
                {
                    nums[k] = arr1[i];
                    i++;
                }
                k++;
            }
            while (i < sizeArr1) 
            {
                nums[k] = arr1[i];
                k++;i++;
            }
            while (j < sizeArr2) 
            {
                nums[k] = arr2[j];
                k++;j++;
            }
           
        }
    }
}
