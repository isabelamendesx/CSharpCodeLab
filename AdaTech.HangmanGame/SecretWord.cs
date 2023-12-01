using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.HangmanGame
{
    internal class SecretWord
    {
        private string word;
        private string hint;
        private char[] guessedLetters;

        public string GetGuessedLetters()
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in guessedLetters)
            {
                result.Append(c + " ");
            }
            return result.ToString();
        }

        public SecretWord(int themeOption)
        {
            try
            {
                var dictOption = WordBank.FindDictionary(themeOption);
                var randomWordandHint = WordBank.GetRandomWordAndHint(dictOption);
                word = randomWordandHint.Key;
                hint = randomWordandHint.Value;
                guessedLetters = new char[word.Length];

                for (int i = 0; i < guessedLetters.Length; i++)
                {
                    guessedLetters[i] = '_';
                }
            }

            catch (InvalidOperationException ex)
            {
                // Lida com a situação em que não há palavras disponíveis
                // Pode lançar uma exceção mais específica ou registrar a exceção, dependendo dos requisitos
                Console.WriteLine($"Error initializing SecretWord: {ex.Message}");
            }
        }
        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public string Hint
        {
            get { return hint; }
            set { hint = value; }
        }

        public bool IsLetterInWord(char letter)
        {
            bool letterGuessed = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    guessedLetters[i] = letter;
                    letterGuessed = true;
                }
            }

            return letterGuessed;

        }

        public bool IsWordGuessed()
        {
            foreach (char c in guessedLetters)
            {
                if (c == '_')
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
