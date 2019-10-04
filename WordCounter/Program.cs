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
            newRepeat.Results(newRepeat);

            
            
        

        }

    }
}