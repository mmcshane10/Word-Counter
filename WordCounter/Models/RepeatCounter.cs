using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string UserString { get; set; }
        public string UserWord { get; set; }
        public int WordCount { get; set; }

        public RepeatCounter(string userString, string userWord)
        {
            UserString = userString.ToLower();
            UserWord = userWord.ToLower();
            WordCount = 0;
        }

        public void CountWord()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '!', '?' };
            string[] wordArray = UserString.Split(delimiterChars);

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == UserWord)
                {
                    WordCount += 1;
                }
            }
        }
    }
}