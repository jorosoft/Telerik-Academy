using NUnit.Framework;
using System;
using _04.LongestSubsequence;

namespace _04.LongestSequence.Tests
{
    [TestFixture]
    public class LongestSequenceTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 4 }, new int[] { 4, 4 })]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 1, 1, 3, 1, 1 }, new int[] { 1, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 })]
        public void GetLongestSubsequence_ShouldReturnCorrectData_WhenCorrectInputIsGiven(int[] sequence, int[] expected)
        {
            var result = Startup.GetLongestSubsequence(sequence);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetLongestSubsequence_ShouldThrowArgumentNullException_WhenNullIsPassed()
        {
            Assert.Throws<ArgumentNullException>(() => Startup.GetLongestSubsequence(null));
        }

        [Test]
        public void GetLongestSubsequence_ShouldThrowArgumentException_WhenNullIsPassed()
        {
            Assert.Throws<ArgumentException>(() => Startup.GetLongestSubsequence(new int[] { }));
        }
    }
}
