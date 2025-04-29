using Algorithms.helpers;

namespace Divide_Conquer.QuickSort
{
    class QuickSort : ParentForAllAlgorithms
    {
       public void QuickSortAlgorithm(int[] nums,int l,int r) 
        {
            if (l < r)
            {
                int pivot = Partition(nums, l, r);
                QuickSortAlgorithm(nums, l, pivot - 1);
                QuickSortAlgorithm(nums, pivot, r);
            }
        }

       public int Partition(int[] nums, int l , int r) 
        {
            int i =l, j=r;
            int mid = l + (r - l) / 2;
            int pivot = nums[mid];
            while (i <= j)
            {
                while (nums[i] < pivot)
                {
                    i++;
                }
                while (nums[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(nums, i, j);
                    i++;
                    j--;
                }
            }
            return i;
            //while (i <= j)
            //{
            //    if (nums[pivot] >= nums[i] && pivot > i)
            //        i++;
            //    else if (nums[pivot] <= nums[j] && pivot < j)
            //        j--;
            //    else if (nums[pivot] < nums[i] && nums[pivot] >= nums[j])
            //    {
            //        Swap(nums, i, j);
            //        i++; j--;
            //    }
            //    else if(pivot == j)
            //    {
            //        Swap(nums, pivot, j);
            //    }

            //}
            //if (pivot == j)
            //{
            //    Swap(nums, pivot, j);
            //}
            //pivot = j;
            //return pivot;

        }
        private void Swap(int[] nums, int l, int r) 
        {
            int tmp = nums[l];
            nums[l] = nums[r];
            nums[r] = tmp;
        }
    }
}
