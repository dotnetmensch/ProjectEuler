using ProjectEuler.Service;
using Xunit;

namespace ProjectEuler.Tests
{
    public class PalindromeTest
    {
        [Fact]
        public void LargestPalindromeTest()
        {
            var largest = new Palindrome().LargestPalindromicOfTwo(2);
            Assert.Equal(9009, largest);
        }
    }
}