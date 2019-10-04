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

        public static void InitApp()
        {
            Console.Clear();
            Console.Write("Please enter a sentence:");
            string userString = Console.ReadLine();
            Console.Write("Enter the word you'd like to count:");
            string userWord = Console.ReadLine();

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);

            newRepeat.CountWord();
            newRepeat.Results(newRepeat);
        }

        public void CountWord()
        {
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '-', '!', '?' };
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
            Console.Clear();

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

            Console.WriteLine("=========================================");
            Console.WriteLine("Please enter one of the numbers below:");
            Console.WriteLine("1. Check another word in my sentence.");
            Console.WriteLine("2. Start over with a new sentence.");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                // CheckAnother();
            }
            else if (userChoice == "2")
            {
                RepeatCounter.InitApp();
            }
        }
    }
}