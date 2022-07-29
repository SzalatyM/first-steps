using Xunit;

namespace FirstSteps.Tests
{
    public class PalindromeTests
    {
        private readonly Palindrome _palindrome;

        public PalindromeTests()
        {
            _palindrome = new Palindrome();
        }

        [Theory]
        [InlineData("anna")]
        [InlineData("level")]
        [InlineData("rotator")]
        [InlineData("kayak")]
        public void IsPalindrome_Should_Return_True(string input)
        {
            Assert.True(_palindrome.IsPalindrome(input));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("abcd")]
        [InlineData("test")]
        public void IsPalindrome_Should_Return_False(string input)
        {
            Assert.False(_palindrome.IsPalindrome(input));
        }
    }
}