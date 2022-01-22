using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public static class Palindrome
    {
        public static long LargestPalindromicOfTwo(int digits)
        {
            string startString = string.Empty;
            var endString = string.Empty;
            for (int k = 0; k < digits; k++)
            {
                startString += "9";
                if (k == 0)
                    endString += "1";
                else
                    endString += "0";
            }
            var start1 = long.Parse(startString);
            var end = long.Parse(endString);

            long result = 0;
            var palindromes = new List<long>();

            for (long i = start1; i >= end; i--)
            {
                for (long j = start1; j >= end; j--)
                {
                    result = i * j;
                    if (result.IsPalindromic())
                        palindromes.Add(result);
                }
            }

            result = palindromes.Max();
            return result;
        }


        private static bool IsPalindromic(this long number)
        {
            var charArray = number.ToString().ToCharArray();
            var reverseCharArray = charArray.Reverse().ToArray();
            return charArray.SequenceEqual(reverseCharArray);
        }
    }
}
