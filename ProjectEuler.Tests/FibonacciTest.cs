using System;
using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class FibonacciTest
    {
        [Fact]
        public void GetEvenFibSumBaseTest()
        {
            var sumOf89 = new Fibonacci().GetSumOfEvenFib(89);
            Assert.Equal(44, sumOf89);
        }
    }
}