using System;
using ProjectEuler.Service;

namespace ProjectEuler.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumOf1000 = new SumOfMultiples().GetSumOfMultiplesOf3And5(1000);
            Console.WriteLine($"Sum of multiples of 3 and 5 for 1,000: {sumOf1000}");

            var sumOf4mil = new Fibonacci().GetSumOfEvenFib(4000000);
            Console.WriteLine($"Sum of even Fibonnaci of 4,000,000: {sumOf4mil}");

            long number = 600851475143;
            var largestPrime = new PrimeFactor().GetLargestPrimeFactor(number);
            Console.WriteLine($"Largest prime factor of {number:N0}: {largestPrime:N0}");

            var largestPalindromicOf3 = new Palindrome().LargestPalindromicOfTwo(3);
            Console.WriteLine($"Largest Palindromic Product of any two 3 digit numbers: {largestPalindromicOf3:N0}");

            var smallestMultiple = new SmallestMultiple().GetSmallestMultiple(1, 20);
            Console.WriteLine($"Smallest multiple of 1 - 20: {smallestMultiple:N0}");

            var sumSquareDifference = new SumSquareDifference().GetSumSquareDifference(1, 100);
            Console.WriteLine($"Sum Square difference of 1 - 100: {sumSquareDifference:N0}");

            Console.ReadLine();
        }
    }
}