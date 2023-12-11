using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.LibrarySystem
{
<<<<<<< HEAD
    internal static class Utilities
=======
    internal class Utilities
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
    {
        public static int LerNumeroInt(string prompt, int min, int max)
        {
            int numero;
            bool numValido = false;

            do
            {
                Console.Write($"\n{prompt}: \n");
                numValido = int.TryParse(Console.ReadLine(), out numero);

                if (!numValido || numero < min || numero > max)
                {
                    Console.WriteLine("Você não digitou um número válido. Tente novamente.");
                }
            } while (!numValido || numero < min || numero > max);

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

        public static string LerString(string prompt)
        {
            string userInput;

            do
            {
                Console.Write($"\n{prompt}: \n");
                userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Você não digitou uma string válida. Tente novamente.");
                }

            } while (string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }
    }
}
