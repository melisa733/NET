using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Console.Read();
        }

        static void Task1()
        {
            string[] words = new string[] {
                "WELL",
                "OKAY",
                "TODAY",
                "HAPPY",
                "SAD"};

            Random rand = new Random();
            int wordIndex = rand.Next(words.Length);

            string[] letters = new string[words[wordIndex].Length];
            string[] guessedLetters = new string[words[wordIndex].Length];
            bool gussed = false;
            string letter;

            Console.WriteLine(words[wordIndex]);
            Console.WriteLine("___________________________");

            // makes a word like "----"
            guessedLetters = StartingPositionForGussedLetterArray(guessedLetters);
            letters = StartingPositionForWordLetterArray(letters, words[wordIndex]);

            PrintingArray(guessedLetters);

            while (!gussed)
            {
                Console.WriteLine("Please enter a letter, to guess a word");
                letter = Console.ReadLine().ToUpper();

                guessedLetters = ModifiesArray(letter, letters, guessedLetters);

                PrintingArray(guessedLetters);

                gussed = CheckingIfGussed(letters, guessedLetters);
            }

            Console.WriteLine("YOU HAVE GUSSED A WORD!");

        }

        static string[] StartingPositionForGussedLetterArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = "-";
            }

            return array;
        }

        static string[] StartingPositionForWordLetterArray(string[] array, string word)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = word[i].ToString();
            }

            return array;
        }

        static void PrintingArray(string[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
        }

        static bool CheckingIfGussed(string[] wordArray, string[] guessedArray) 
        {
            bool guessed = true;

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] != guessedArray[i]) 
                {
                    guessed = false;
                }
            }

            return guessed;
        }

        static string[] ModifiesArray(string letter, string[] wordArray, string[] guessesLetterArray)
        {
            bool isLetter = false;
            for (int i = 0; i < wordArray.Length; i++) 
            {
                if (letter == wordArray[i]) 
                {
                    guessesLetterArray[i] = letter;
                    isLetter = true;
                }
            }

            if (!isLetter) {
                Console.WriteLine("There isn't a {0} letter", letter);
            }

            return guessesLetterArray;
        }


    }
}
