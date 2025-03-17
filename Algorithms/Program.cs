using Algorithms.BruteForce;
using Algorithms.DivideAndConquer;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BinarySearch
            //BinarySearch binarySearch = new BinarySearch();
            //int[] numbers = [2, 7, 8, 18, 20, 24, 29, 36, 40, 45, 51, 53, 60, 65, 69, 77, 81, 85, 91, 97];
            //int target = 65;
            //int result = binarySearch.FindElementWithBinarySearch(numbers, 65);
            //Console.WriteLine(result);
            #endregion

            #region SelectionSort
            //SelectionSort selectionSort = new SelectionSort();
            //int[] res = selectionSort.selectionSort(new int[] { 5, 4, 3, 7, 1, 8, 9, 2, 12, 6 });
            //foreach(var item in res)
            //Console.WriteLine(item); 
            #endregion

            #region BubbleSort
            //BubbleSort bubbleSort = new BubbleSort();
            //int[] res = bubbleSort.BubbleSortAlgorithm(new int[] { 12, 4, 3, 7, 1, 8, 9, 2, 5, 6 });
            //foreach (var item in res)
            //Console.WriteLine(item); 
            #endregion

            #region InsertionSort
            //InsertionSort insertionSort = new InsertionSort();
            //int[] res = insertionSort.InsertionSortAlgorithm([12, 4, 3, 7, 1, 8, 9, 2, 5, 6]);
            //foreach (var item in res)
            //    Console.WriteLine(item);
            #endregion

            #region MergeSort
            MergeSort mergeSort = new MergeSort();
            int[] arr = [12, 4, 3, 7, 1, 8, 9, 2, 5, 6];
            Console.WriteLine("Original Arr: ");
            mergeSort.Print(arr);
            Console.WriteLine("Sorted Arr: ");
            mergeSort.Sort(arr, 0, arr.Length-1);
            mergeSort.Print(arr);
             
           
                #endregion
        }
    }
}
