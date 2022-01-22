using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class PrimeFactorTest
    {
        [Fact]
        public void GetLargestPrimeFactorTest()
        {
            var largest = new PrimeFactor().GetLargestPrimeFactor(13195);
            Assert.Equal(29, largest);
        }
    }
}