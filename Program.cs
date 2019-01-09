using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "cat";
            string guess = " ";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
              if (guessCount < guessLimit)
              {
                Console.Write("I'm thinking of a word...");
                Console.Write("Guess what word I'm thinking of: ");
                guess = Console.ReadLine();
                guessCount++;
                int guessesRemaining = guessLimit - guessCount;
                if (guess != secretWord)
                {
                Console.Write("You have " + guessesRemaining + " guesses left!  ");
                }
              }
              else
              {
                outOfGuesses = true;
              }
            }
            if (outOfGuesses)
            {
              Console.Write("You lose!");
            }
            else
            {
              Console.Write("You Win!");
            }

            Console.ReadLine();
        }
    }

}
