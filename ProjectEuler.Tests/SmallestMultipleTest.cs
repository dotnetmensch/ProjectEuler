using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class SmallestMultipleTest
    {
        [Fact]
        public void SmallestMultiple_Test()
        {
            var smallestMultipe = new SmallestMultiple().GetSmallestMultiple(1, 10);
            Assert.Equal(2520, smallestMultipe);
        }
    }
}