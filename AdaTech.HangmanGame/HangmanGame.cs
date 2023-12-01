using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.HangmanGame
{
    internal class HangmanGame
    {
        public int handleMenuChoose()
        {
            int menuChoose = 0;
            do
            {
                Console.Clear();
                UserInterface.ShowHangmanGame();
                UserInterface.ShowMenu();
                menuChoose = LerNumero("Type your choose");


                UserInterface.ShowOptionMessage(menuChoose);

                Console.WriteLine("Press 'y' to continue or any other key to choose again");
            } while (Console.ReadLine().ToLower() != "y");

            return menuChoose;
        }

        public void handleGame(SecretWord secretWord)
        {
            char? inputLetter = '\0';
            int hangmanLevel = 0;
            List<char> triedLetters = new List<char>();
            do
            {
                Console.Clear();
                UserInterface.ShowHangmanGame();
                UserInterface.ShowHangman(hangmanLevel);
                Console.WriteLine("YOUR TRIED LETTERS: ");
                triedLetters.ForEach(ch => Console.Write(ch + " "));
                Console.WriteLine();

                UserInterface.showSecretWord(secretWord);

                inputLetter = LerLetraOuZero("Type one letter or 0 to exit");


                if (secretWord.IsLetterInWord(inputLetter.Value))
                {
                    Console.WriteLine("YES! YOU HIT!");
                }
                else
                {
                    Console.WriteLine("TRY AGAIN");
                    triedLetters.Add(inputLetter.Value);
                    hangmanLevel++;
                }
            } while (hangmanLevel < 7 && !secretWord.IsWordGuessed() && (inputLetter == null || inputLetter.Value != '0'));

            Console.Clear();
            if (hangmanLevel == 7) UserInterface.ShowLooseMessage();
            else if(secretWord.IsWordGuessed()) UserInterface.ShowWinMessage();


        }
        



        public void MatchHandle()
        {
            do
            {
                int menuOption = handleMenuChoose();


                SecretWord secretWord = new SecretWord(menuOption);


                handleGame(secretWord);

                Console.WriteLine("\nPress 'y' to play again or any other key to exit");
            } while (Console.ReadLine().ToLower() == "y");

        }

        public static int LerNumero(string prompt)
        {
            int numero;
            bool numValido = false;

            do
            {
                Console.Write($"\n{prompt}: \n");
                numValido = int.TryParse(Console.ReadLine(), out numero);

                if (!numValido || numero < 1 || numero > 4)
                {
                    Console.WriteLine("Você não digitou um número válido. Tente novamente.");
                }
            } while (!numValido || numero < 1 || numero > 4);

            return numero;
        }

        public static char LerLetraOuZero(string prompt)
        {
            char letra = '\0';
            bool entradaValida = false;

            do
            {
                Console.Write($"\n{prompt}: \n");
                string input = Console.ReadLine();

                if (input.Length == 1 && (char.IsLetter(input[0]) || input[0] == '0'))
                {
                    letra = char.ToLower(input[0]); // Convertendo para minúscula
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Você não digitou uma letra válida ou 0. Tente novamente.");
                }

            } while (!entradaValida);

            return letra;
        }


    }
}
