using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class SumOfMultiples
    {
        public static long GetSumOfMultiplesOf3And5(long upperbound)
        {
            long result = 0;
            for (long i = 0; i < upperbound; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
