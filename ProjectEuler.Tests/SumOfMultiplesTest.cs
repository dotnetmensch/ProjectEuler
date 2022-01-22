using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class SumOfMultiplesTest
    {
        [Fact]
        public void GetSumOfMultiplesOf3And5Test()
        {
            var sumOf10 = new SumOfMultiples().GetSumOfMultiplesOf3And5(10);
            Assert.Equal(23, sumOf10);
        }
    }
}