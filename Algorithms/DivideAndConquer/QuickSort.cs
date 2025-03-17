namespace Algorithms.DivideAndConquer
{
    class QuickSort : ParentForAllAlgorithms
    {
       public void QuickSortAlgorithm(int[] nums,int l,int r) 
        {
            if (l < r)
            {
                int pivot = Partition(nums, l, r);
                QuickSortAlgorithm(nums, l, pivot - 1);
                QuickSortAlgorithm(nums, pivot + 1, r);
            }
        }

       public int Partition(int[] nums, int l , int r) 
        {
            int i =l+1, j=r, tmp;

            int pivot = l;
            while (i<=j) 
            {
                if (nums[pivot] > nums[i] && pivot < i)
                    i++;
                else if (nums[pivot] < nums[j] && pivot < j)
                    j--;
                else if (nums[pivot] < nums[i] && nums[pivot] > nums[j])
                {
                     tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    i++; j--;
                }
              
            }
            if (i>j) 
            {
                tmp = nums[pivot];
                nums[pivot] = nums[j];
                nums[j] = tmp;

            }
            pivot = j;
            return pivot;
       
        }
    }
}
