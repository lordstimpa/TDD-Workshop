using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WordLibTests
    {
        [TestMethod]
        public void IsWordPalindromeTest()
        {
            Worder worder = new Worder();

            string expectedResult = "racecar";
            string input = "racecar";

            string actualResult = worder.IsPalindrome(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}