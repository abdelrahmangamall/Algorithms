using Algorithms.Dynamic_Programming;

namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fib With DP
            //Fibonaccu fib = new Fibonaccu();
            //int[] arr = fib.FibWithButtomUp(5);
            //fib.Print(arr);


            //int res = fib.FibWithTopDown(5);
            //Console.WriteLine($"Fib {5} = {res}");
            #endregion

            #region Assembly Line 
            //var scheduler = new AssemblyLineScheduling();

            //int n = 4;
            //scheduler.dp = new int[n, 2];

            //for (int i = 0; i < n; i++)
            //    for (int j = 0; j < 2; j++)
            //        scheduler.dp[i, j] = -1;

            //int timeLine1 = scheduler.MinTime(n-1, 0) + scheduler.x[0];
            //int timeLine2 = scheduler.MinTime(n-1, 1) + scheduler.x[1];

            //int res = Math.Min(timeLine1, timeLine2);
            //Console.WriteLine("Minimum time to complete the assembly: " + res);
            #endregion

            #region Cut Rod 
            RodCutting rod = new RodCutting();

            #region with Recursion(top to Down)
            //int max= rod.CR_Recursion(10);
            // Console.WriteLine(max); 
            #endregion


            #region With iterative(Bottum to Up)
            //int res=  rod.CR_BuildingTable(10);
            //Console.WriteLine(res);
            #endregion
            #endregion

            #region Edit Distance
            EditDistance distance = new EditDistance();

            distance.s1 = "cat";
            distance.s2 = "hate";
            #region Recurisve


            //int len1 = distance.s1.Length;
            //int len2 = distance.s2.Length;
            //int minSteps = distance.ED_BF_Recursion(len1, len2);
            //Console.WriteLine(minSteps); 
            #endregion
            #region DP
            //string s1 = "cat";
            //string s2 = "hate";
            // int res = distance.ED_DP_ButtomUp(s1, s2);
            //Console.WriteLine($"Edit Distance between \"{s1}\" and \"{s2}\" is: {res}");

            #endregion
            #endregion

            #region Knapsack
            //Knapsack knapsack = new Knapsack();
            //int n = knapsack.w.Length;

            ////int res = knapsack.kS_BruteForce(30,n);
            //// Console.WriteLine(res);


            //int W = 30;

            //knapsack.dp = new int[W + 1, n + 1];

            //for (int i = 0; i <= W; i++)
            //    for (int j = 0; j <= n; j++)
            //        knapsack.dp[i, j] = -1;

            //int resWithDP = knapsack.KS_DP_TopDown(W, n);

            //Console.WriteLine($"resWithDP topDown: {resWithDP}");
            #endregion
        }
        }
    }
