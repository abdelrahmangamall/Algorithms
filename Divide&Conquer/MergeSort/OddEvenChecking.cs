using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer.MergeSort
{
    class OddEvenChecking
    {
        public bool EvOddChecking(int[] arr, int l, int r) 
        {
            if (l == r)
            {
                if (arr[r] % 2 == 0) return false;
                else return true;
            }

            int m = l + (r - l) / 2;

           bool s= EvOddChecking(arr, l, m);
            bool p= EvOddChecking(arr, m+1, r);

            if (s == p)
                return false;
            else return true;

        }
    }
}
