using Algorithms.DivideAndConquer;
using Divide_Conquer.Binary_Search;

namespace Divide_Conquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MergeSort
            //MergeSort mergeSort = new MergeSort();
            //int[] arr = [12, 4, 3, 7, 1, 8, 9, 2, 5, 6];
            //Console.WriteLine("Original Arr: ");
            //mergeSort.Print(arr);
            //Console.WriteLine("Sorted Arr: ");
            //mergeSort.Sort(arr, 0, arr.Length - 1);
            //mergeSort.Print(arr);
            #endregion

            #region QuickSort
            //QuickSort quickSort = new QuickSort();
            //int[] arr2 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
            //int[] arr = [5, 4, 3, 7, 1, 7, 7, 2, 0, 6];
            //Console.WriteLine("Original Arr: ");
            //quickSort.Print(arr);

            //Console.WriteLine("Sorted Arr: ");
            //quickSort.QuickSortAlgorithm(arr, 0, arr.Length - 1);
            //quickSort.Print(arr);


            #endregion

            #region BinarySearch
            //SearchInsertPosition search = new SearchInsertPosition();
            //int[] numbers = [1, 3, 5, 6];
            //int target =2;
            //int result = search.SearchInsert(numbers, target);
            //Console.WriteLine($"the  target:{target} in element {result}");


            UniModelSearch uni = new UniModelSearch();
            int[] a = {1,2,3,4,5,9,8,7,6};
            int res = uni.UniSearch(a, 0, a.Length);
            Console.WriteLine(res);
            #endregion

        }
    } 
}
