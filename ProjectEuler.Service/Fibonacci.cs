namespace ProjectEuler.Service
{
    public class Fibonacci
    {
        public long GetSumOfEvenFib(long upperBound)
        {
            var result = 0;
            var a = 1;
            var b = 2;
            while (a < upperBound)
            {
                if (a % 2 == 0)
                    result += a;

                var c = a + b;
                a = b;
                b = c;
            }

            return result;
        }
    }
}
