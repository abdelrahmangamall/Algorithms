using Algorithms.BruteForce;
using Algorithms.DivideAndConquer;
using Algorithms.Dynamic_Programming;

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
            //MergeSort mergeSort = new MergeSort();
            //int[] arr = [12, 4, 3, 7, 1, 8, 9, 2, 5, 6];
            //Console.WriteLine("Original Arr: ");
            //mergeSort.Print(arr);
            //Console.WriteLine("Sorted Arr: ");
            //mergeSort.Sort(arr, 0, arr.Length-1);
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

            #region Fib With DP
            //Fibonaccu fib = new Fibonaccu();
            //int[] arr = fib.FibWithButtomUp(5);
            //fib.Print(arr);


            //int res =fib.FibWithTopDown(5);
            //Console.WriteLine($"Fib {5} = {res}.");
            #endregion

            #region Assembly Line 
            var scheduler = new AssemblyLineScheduling();
            int n = 4;
            
            int timeLine1 = scheduler.MinTime(n - 1, 0) + scheduler.x[0];
            int timeLine2 = scheduler.MinTime(n - 1, 1) + scheduler.x[1];

            int res = Math.Min(timeLine1, timeLine2);
            Console.WriteLine("Minimum time to complete the assembly: " + res);
            #endregion
        }
    }
}
