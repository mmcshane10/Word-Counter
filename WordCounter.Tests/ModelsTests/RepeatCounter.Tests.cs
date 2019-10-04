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
            string userString = "One cat, two cat, red cat, blue cat.";
            string userWord = "cat";

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);

            newRepeat.CountWord();
            int output = newRepeat.WordCount;
            Assert.AreEqual(4, output);
        }

    }
}