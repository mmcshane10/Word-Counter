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

        public void Results(RepeatCounter newRepeat)
        {
            if (newRepeat.WordCount == 1)
            {
                Console.WriteLine("The word " + newRepeat.UserWord + " is in your sentence " + newRepeat.WordCount + " time.");
            }
            else if (newRepeat.WordCount == 0)
            {
                Console.WriteLine("Sorry, we couldn't find any instances of " + newRepeat.UserWord + " in your sentence.");
            }
            else
            {
                Console.WriteLine("The word " + newRepeat.UserWord + " is in your sentence " + newRepeat.WordCount + " times.");
            }
        }
    }
}