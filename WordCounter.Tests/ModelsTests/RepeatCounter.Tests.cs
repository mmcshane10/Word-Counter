using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void CountWord_CountInstancesofWord_One()
        {
        string userString = "The cat is old";
        string userWord = "cat";

        RepeatCounter newRepeat = new RepeatCounter (userString, userWord);

        newRepeat.CountWord();
        int output = newRepeat.WordCount;
        Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void CountWord_CanHandleCapitalizedSpellings_One()
        {
            string userString = "The Cat is old";
            string userWord = "cat";

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);

            newRepeat.CountWord();
            int output = newRepeat.WordCount;
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void CountWord_SkipsPartialMatches_One()
        {
            string userString = "The cat is a caterer";
            string userWord = "cat";

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);

            newRepeat.CountWord();
            int output = newRepeat.WordCount;
            Assert.AreEqual(1, output);
        }

        [TestMethod]
        public void CountWord_CountsMultipleMatches_Four()
        {
            string userString = "One Cat, two Cat, red Cat, blue Cat.";
            string userWord = "cat";

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);

            newRepeat.CountWord();
            int output = newRepeat.WordCount;
            Assert.AreEqual(4, output);
        }
    }
}