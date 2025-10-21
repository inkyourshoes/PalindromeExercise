using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("race car", false)]
        [InlineData("wow", true)]
        
        public void MyTest(string word, bool expected)
        {
            var tester = new WordSmith();                    //arrange
            bool actual = WordSmith.IsAPalindrome(word);        //act
            Assert.Equal(expected, actual);                //assert 
            
        }
    
        
    }
}
