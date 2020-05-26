using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture100320
{
    class HangmanGame
    {
        List<string> Words = new List<string>();
        char[] Word;
        char[] GuessedWord;
        int livesHasBeenLost;

        public HangmanGame()
        {
            Words.Add("HAPPY");
            Words.Add("SAD");
            Words.Add("GOOD");
            Words.Add("BAD");
            Words.Add("TODAY");
        }

        public void NewGame() {

            livesHasBeenLost = 0;
            Random rand = new Random();
            int index = rand.Next(Words.Count);
            Word = Words[index].ToCharArray();
            GuessedWord = new char[Words[index].Length];

            for (int i = 0; i < Words[index].Length; i++) {
                GuessedWord[i] = '-';
            }
        }

        public bool IsWordGussed()
        {
            bool IsWordGussed = true;

            foreach (char letter in GuessedWord) {
                if (letter == '-') 
                {
                    IsWordGussed = false;
                    break;
                }
            }

            return IsWordGussed;
        }

        public bool Guess(char letter) {
            bool GuesedLetter = false;
            letter = char.ToUpper(letter);

            for (int i = 0; i < Word.Length; i++) {
                if (Word[i] == letter) {
                    GuesedLetter = true;
                    GuessedWord[i] = letter;
                }
            }

            if (GuesedLetter == false) {
                livesHasBeenLost++;
            }

            return GuesedLetter;
        }

        public string GetWord() {
            string word = "";

            foreach (char letter in GuessedWord)
            {
                word = word + letter;
            }

                return word;
        }

        public bool IsGameOver() 
        {
            if (livesHasBeenLost < 5)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public int GetLivesHasBeenLost() 
        {
            return livesHasBeenLost;
        }
    }

}
