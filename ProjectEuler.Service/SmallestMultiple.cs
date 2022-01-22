using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class SmallestMultiple
    {
        public static long GetSmallestMultiple(int start, int end)
        {
            long result = 0;
            bool success = true;
            do
            {
                result++;
                for (int i = start; i <= end; i++)
                {
                    if (result % i != 0)
                        success = false;
                }
            } while (!success);

            return result;
        }
    }
}
