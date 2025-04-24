namespace Algorithms.DivideAndConquer
{
    public class BinarySearch
    {

        //I Will take Sorted Array
        public int FindElementWithBinarySearch(int[] arr, int target) 
        {
            int length = arr.Length;
            int right = length - 1;
            int left = 0;
            if (length == null) 
            {
                return -1;
            }

            while (length != 1)
            {
              int middle = left + (right - left) / 2;

                if (arr[middle] == target)
                {
                    return arr[middle];
                }
                else if (arr[middle] < target)
                {
                    left = middle + 1;

                }
                else if (arr[middle] > target)
                {
                    right = middle - 1;
                    middle = (left + right) / 2;
                }
            } 
            return -1;

        }
    }
}
