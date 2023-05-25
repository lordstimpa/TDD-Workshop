using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WordLibTests
    {
        [TestMethod]
        public void IsWordPalindrome()
        {
            Worder worder = new Worder();

            string expectedResult = "racecar";
            string input = "racecar";

            string actualResult = worder.IsPalindrome(input);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void IsWordInputEmpty()
        {
            Worder worder = new Worder();

            bool expectedResult = true;
            string input = "";

            bool actualResult = worder.IsEmpty(input);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}