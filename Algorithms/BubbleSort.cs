namespace BruteForce
{
    class BubbleSort
    {

        public int[] BubbleSortAlgorithm(int[] nums) 
        {

            int len = nums.Length;
            bool swapped; 
            for (int i = 0; i < len-1; i++) 
            {
                swapped =false;
                for (int j = 0; j < len-i-1; j++) 
                {
                    if (nums[j] > nums[j+1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j+1] = tmp;
                      
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }
            return nums;
        }
    }
}
