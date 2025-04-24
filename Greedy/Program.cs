using Algorithms.Greedy;

namespace Greedy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MaxSequenceSum
            MaxSequenceSum max = new MaxSequenceSum();
            int[] arr = { 31, -41, 59, 26, -53, 58, 97, -93, -23, 84 };
            int res = max.MaxSeqSum(arr);
            Console.WriteLine(res); 
            #endregion
        }
    }
}
