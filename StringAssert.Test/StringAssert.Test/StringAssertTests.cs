using Programm;

namespace StringAssert.Test
{
    [TestClass]
    public class StringAssertTests
    {
        [TestMethod]
        public void ShortestWord_longsentence_true()
        {
            string input = "Think Gura, you or you will be in the box";
            string expected = "or";
            StringAsserts word = new StringAsserts();
            string actual = word.ShortestWord(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountWord_sentence_true()
        {
            string input = "Think Gura";
            int expected = 2;
            StringAsserts word = new StringAsserts();
            int actual = word.CountWord(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountCharacters_sentence_false()
        {
            string input = "Think Gura";
            int expected = 11; 
            StringAsserts word = new StringAsserts();
            int actual = word.CountCharacters(input);
            Assert.AreNotEqual(actual, expected);
        }

        [TestMethod]
        public void FindNinhCharacter_longsentence_fail()
        {
            string input = "Think Gura, you or you will be in the box";
            char expected = 'a'; 
            StringAsserts word = new StringAsserts();
            char actual = word.FindNinthCharacter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountDigt_longsentence_Notnull()
        {
            string input = "Think Gura, you or you will be in the box";
            int expected = 0;
            StringAsserts word = new StringAsserts();
            int actual = word.CountDigits(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LongestNumbers_longsentence_true()
        {
            string input = "Think2342546 Gura4325, you  or4334 you will be in the box";
            int expected = 7;
            StringAsserts word = new StringAsserts();
            int actual = word.LongestNumbers(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountSubstrings_longsentence_true()
        {
            string input = "amama";
            int expected = 2;
            StringAsserts word = new StringAsserts();
            int actual = word.CountSubstrings(input); 
            Assert.AreEqual(expected, actual);
        }
    }
}