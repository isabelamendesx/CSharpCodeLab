using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace AdaTech.LibrarySystem
{
    internal static class UserInterface
    {
        public static void ShowLibraryWelcome()
        {
            string libraryTitle = FiggleFonts.Standard.Render("Isa 's  Library");
            Console.WriteLine(libraryTitle);
            Console.WriteLine("Welcome to Isa's library\n");
        }

        public static void ShowLibraryMenu()
        {
     
            Console.WriteLine("+===============================+");
            Console.WriteLine("|      * CHOOSE AN OPTION *     |");
            Console.WriteLine("|      1. Rent a book           |");
            Console.WriteLine("|      2. Return a book         |");
            Console.WriteLine("|      3. Find a book           |");
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
    }
}
