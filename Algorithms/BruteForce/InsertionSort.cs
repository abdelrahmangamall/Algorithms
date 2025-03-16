namespace Algorithms.BruteForce
{
    class InsertionSort
    {
        public int[] InsertionSortAlgorithm(int[] nums) 
        {
            int len = nums.Length;  
            for (int i = 1; i < len; i++)
            {
                int k = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] > k) 
                {

                    nums[j+1] = nums[j];
                    j--;
                }
                nums[j + 1] = k;

            }

            return nums;
        } 
    }
}
