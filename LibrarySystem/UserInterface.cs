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
            Console.WriteLine("+===============================|\n");
        }

        public static void ShowSearchMenu()
        {

            Console.WriteLine("+===============================+");
            Console.WriteLine("|      * SEARCH FOR A BOOK *    |");
            Console.WriteLine("|   1. By author                |");
            Console.WriteLine("|   2. By genre                 |");
            Console.WriteLine("|   3. By title                 |");
            Console.WriteLine("|   4. View our complete list   |");
            Console.WriteLine("+===============================|\n");
        }

        public static void ShowSerchOptionMessage(int menuChoose)
        {
            switch (menuChoose)
            {
                case 1:
                    Console.WriteLine("You search SEARCH BY TITLE\n");
                    break;
                case 2:
                    Console.WriteLine("You chose SEARCH BY GENRE\n");
                    break;
                case 3:
                    Console.WriteLine("You chose SEARCH BY AUTHOR\n");
                    break;
                case 4:
                    Console.WriteLine("You chose VIEW OUR COMPLETE LIST");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha novamente.");
                    break;
            }

        }

        public static void showBookList(List<Dictionary<string, string>> listToShow)
        {
            foreach (var book in listToShow)
            {
                Console.WriteLine($"ID: {book["id"]}, Título: {book["title"]}, Autor: {book["author"]}" +
                    $"\n STATUS: {book["status"]}");
            }
        }

        public static void showBook(Dictionary<string, string> bookToShow)
        {
                Console.WriteLine($"ID: {bookToShow["id"]}, Título: {bookToShow["title"]}, Autor: {bookToShow["author"]}" +
                   $"\n STATUS: {bookToShow["status"]}");      
        }



        public static void ShowMenuOptionMessage(int menuChoose)
        {
            switch (menuChoose)
            {
                case 1:
                    Console.WriteLine("You chose RENT A BOOK\n");
                    break;
                case 2:
                    Console.WriteLine("You chose RETURN A BOOK\n");
                    break;
                case 3:
                    Console.WriteLine("You chose FIND A BOOK\n");
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
