using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    internal static class Utilities
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
                    Console.WriteLine("You didn't type a valid number. Plese try again");
                }
            } while (!numValido || numero < min || numero > max );

            return numero;
        }

        public static string LerPrimeiraPalavra(string prompt)
        {
            string input;
            bool palavraValida;

            do
            {
                Console.Write($"{prompt} ");
                input = Console.ReadLine();
                palavraValida = !string.IsNullOrWhiteSpace(input);

                if (!palavraValida)
                {
                    Console.WriteLine("You must enter a non-empty word. Please try again.");
                }

            } while (!palavraValida);

            int index = input.IndexOf(' ');
            return index == -1 ? input : input.Substring(0, index);
        }
    

    public static DateTime LerData(string prompt, DateTime min)
        {
            DateTime data;
            bool dataValida = false;

            do
            {
                Console.Write($"{prompt}: ");
                string dataInput = Console.ReadLine();
o
                dataValida = DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data);

                if (!dataValida || data < min)
                {
                    Console.WriteLine("Você não digitou uma data válida. Por favor, tente novamente.");
                }

            } while (!dataValida || data < min);

            return data;
        }

        public static DateTime LerDataExata(string prompt, DateTime exactDate)
        {
            DateTime data;
            bool dataValida = false;

            do
            {
                Console.Write($"{prompt}: ");
                string dataInput = Console.ReadLine();

                dataValida = DateTime.TryParseExact(dataInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data);

                if (!dataValida && data != exactDate)
                {
                    Console.WriteLine("Essa não é a data da sua reserva. Tente novamente");
                }

            } while (!dataValida || data != exactDate);

            return data;
        }




    }
}
