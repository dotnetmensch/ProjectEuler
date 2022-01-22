namespace ProjectEuler.Service
{
    public class SmallestMultiple
    {
        public long GetSmallestMultiple(int start, int end)
        {
            long result = end - 1;
            int remainder;
            do
            {
                result++;
                remainder = 0;
                for (int i = start; i <= end; i++)
                {
                    remainder = (int)(result % i);
                    if(remainder != 0)
                        break;
                }
            } while (remainder != 0);

            return result;
        }
    }
}
