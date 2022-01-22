using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class SumSquareDifferenceTest
    {
        [Fact]
        public void GetSumSquareDifferenceTest()
        {
            var result = new SumSquareDifference().GetSumSquareDifference(1, 10);
            Assert.Equal(2640, result);
        }
    }
}