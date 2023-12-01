using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace AdaTech.HangmanGame
{
    internal static class UserInterface
    {
        public static void ShowHangmanGame()
        {
            string hangmanGameText = FiggleFonts.Standard.Render("Hangman Game");
            Console.WriteLine(hangmanGameText);
        }

        public static void ShowLooseMessage()
        {
            string looseMessage = FiggleFonts.Standard.Render("OH NO! YOU LOOSE..");
            Console.WriteLine(looseMessage);
        }

        public static void ShowWinMessage()
        {
            string winMessage = FiggleFonts.Standard.Render("WIN! YOU GUESS THE WORD");
            Console.WriteLine(winMessage);
        }

        public static void ShowHangman(int numberOfErrors)
        {
            switch (numberOfErrors)
            {
                case 0:
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    break;

                case 1:
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    break;

                case 2:
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|\\");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|\\");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |         / ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("    +==========+");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |          O");
                    Console.WriteLine("    |         /|\\");
                    Console.WriteLine("    |          |");
                    Console.WriteLine("    |         / \\");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("    |           ");
                    Console.WriteLine("+--------------------------");
                    Console.ResetColor();
                    break;

                // Adicione mais casos conforme necessário para lidar com mais erros.

                default:
                    Console.WriteLine("Invalid number of errors.");
                    break;
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to HANGMAN GAME\n");
            
            Console.WriteLine("+===============================+");
            Console.WriteLine("|      * CHOOSE A TOPIC *       |");
            Console.WriteLine("|      1. Tech / Computers      |");
            Console.WriteLine("|      2. Countries             |");
            Console.WriteLine("|      3. Animals               |");
            Console.WriteLine("|      4. Soccer teams          |");
            Console.WriteLine("+===============================|");
        }

        public static void ShowOptionMessage(int menuChoose)
        {
            switch (menuChoose)
            {
                case 1:
                    Console.WriteLine("You chose TECH/COMPUTERS\n");
                    break;
                case 2:
                    Console.WriteLine("You chose COUNTRIES\n");
                    break;
                case 3:
                    Console.WriteLine("You chose ANIMALS\n");
                    break;
                case 4:
                    Console.WriteLine("You chose SOCCER TEAMS");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }

        }

        public static void showSecretWord(SecretWord secretWord)
        {
            Console.WriteLine($"*************** HINT: {secretWord.Hint} *******************");
            Console.WriteLine($"{secretWord.GetGuessedLetters()}\n");
        }
    }
}
