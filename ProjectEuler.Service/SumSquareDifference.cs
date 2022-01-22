using System;

namespace ProjectEuler.Service
{
    public class SumSquareDifference
    {
        public int GetSumSquareDifference(int start, int end)
        {
            var sumOfSquares = 0;
            for (int i = start; i <= end; i++)
            {
                sumOfSquares += i * i;
            }

            var squareOfSum = 0;
            for (int i = start; i <= end; i++)
            {
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            return squareOfSum - sumOfSquares;
        }
    }
}