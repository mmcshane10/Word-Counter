using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Please enter a sentence:");
            string userString = Console.ReadLine();
            Console.Write("Enter the word you'd like to count:");
            string userWord = Console.ReadLine();

            RepeatCounter newRepeat = new RepeatCounter(userString, userWord);
            newRepeat.CountWord();
            
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