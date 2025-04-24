namespace Algorithms.BruteForce
{
    class SelectionSort
    {
        public int[] selectionSort(int[] numbers) 
        {
            int len = numbers.Length;
            for (int i = 0; i < len-1; i++) 
            {
                int minIndex = i;
                for (int j = i + 1; j < len; j++) 
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                        
                    }
                }
                if (minIndex!=i)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = tmp;
                    
                }
            }
            return numbers;
        }
    }
}
