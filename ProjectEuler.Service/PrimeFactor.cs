namespace ProjectEuler.Service
{
    public class PrimeFactor
    {
        public long GetLargestPrimeFactor(long number)
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
