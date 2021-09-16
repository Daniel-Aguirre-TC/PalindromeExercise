using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        public void IsAPalindrome(string input, bool expected)
        {
            var obj = new WordSmith();

            var actual = obj.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
    }
}
