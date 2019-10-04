using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string UserString { get; set; }
        public string UserWord { get; set; }
        public int WordCount { get; set; }

        public RepeatCounter(string userString, string userWord, int WordCount)
        {
            UserString = userString;
            UserWord = userWord;
            WordCount = 0;
        }
    }
}