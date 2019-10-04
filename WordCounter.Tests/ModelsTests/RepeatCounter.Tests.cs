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

    }
}