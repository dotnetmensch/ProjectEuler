namespace ProjectEuler.Service
{
    public class SumOfMultiples
    {
        public long GetSumOfMultiplesOf3And5(long upperbound)
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
