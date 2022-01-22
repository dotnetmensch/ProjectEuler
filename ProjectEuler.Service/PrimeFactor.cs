using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class PrimeFactor
    {
        public static long GetLargestPrimeFactor(long number)
        {
            long factor = 2;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    number /= factor;
                }
                else
                {
                    factor++;
                }
            }

            return number;
        }

    }
}
