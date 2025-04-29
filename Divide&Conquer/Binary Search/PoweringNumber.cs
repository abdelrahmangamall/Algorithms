using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Conquer.Binary_Search
{
    class PoweringNumber
    {
        public int PowrNumber(int a, int n) 
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return a;


            int m = n / 2;
           int p= PowrNumber(a, m);

            if (n % 2 == 0)
                return p * p;
            else
                return p * p * a;

        }
    }
}
