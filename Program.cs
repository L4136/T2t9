using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2t9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Word Guess Game\nYou will be hanged after ten guesses.");

            //initializing the word
            string theWord = "game of thrones rules";
            char[] charWord = theWord.ToCharArray();

            //figuring out lenght of the word
            int charLenght = 0;
            foreach (char c in charWord)
            {
                charLenght++;
            }

            //initializing maximum amount of guesses
            int maxGuesses = charLenght * 2;

            //guessCount equals to amount of guessed letters
            int guessCount = 0;

            //initializing the visible word
            char[] charReveal = new char[charLenght];
            for (int i = 0; i < charLenght; i++)
            {
                charReveal[i] = '_';
            }

            //guessedLetters is used to display already tried letters
            string guessedLetters = null;

            //initializing the game
            while (guessCount < maxGuesses)
            {
                //getting letters from the player and checking if it matches the Word
                //if match, then add and display the letter in the Word
                Console.Write("Guess a letter: ");
                string answerLetter = Console.ReadLine();
                char guess = System.Convert.ToChar(answerLetter);
                for (int i = 0; i < charLenght; i++)
                {
                    if (charWord[i] == guess)
                    {
                        charReveal[i] = guess;
                    }
                    Console.Write(charReveal[i]);
                }

                //adding the guess to the already tried letters
                guessedLetters = guessedLetters + answerLetter;
                Console.WriteLine();

                //if all characters are revealed, then win
                //tried string matchCheck = charReveal.ToString();
                //      if (matchCheck.CompareTo(theWord) == 0)
                //      didn't work
                int revealCount = 0;
                for (int i = 0; i < charLenght; i++)
                {
                    if (charReveal[i] != '_')
                    {
                        revealCount++;
                    }
                }
                if (revealCount == charLenght)
                {
                    Console.WriteLine("Congratulations! You guessed the word!");
                    break;
                }

                //updating already tried letters
                Console.Write("Already guessed letters: " + guessedLetters);
                Console.WriteLine();

                //fail condition
                guessCount++;
                if (guessCount == maxGuesses)
                {
                    Console.WriteLine("You failed to guess the word!");
                }
            }
        }
    }
}
