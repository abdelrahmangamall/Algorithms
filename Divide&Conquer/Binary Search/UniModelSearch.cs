using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer.Binary_Search
{
    class UniModelSearch
    {

        public int UniSearch(int[] arr, int l, int r) 
        {
            if (l == r)
                return arr[l];

            int m = l + (r - l) / 2;

            if (arr[m] > arr[m + 1] && arr[m] > arr[m - 1])
                return arr[m];
            else if (arr[m] < arr[m + 1]) 
              return  UniSearch(arr, m+1, r);
            else
              return  UniSearch(arr, 0, m);

        }
    }
}
