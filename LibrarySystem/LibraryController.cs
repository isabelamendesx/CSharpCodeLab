using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.LibrarySystem
{
    internal class LibraryController
    {
<<<<<<< HEAD
        public void HandleSession(BookLibrary bookLibrary){
            do
            {
                
                UserInterface.ShowLibraryWelcome();
                UserInterface.ShowLibraryMenu();    
                HandleMenuChoice(bookLibrary);


            }while (true);

        }

        public void HandleMenuChoice(BookLibrary bookLibrary) {
            int choice = Utilities.LerNumeroInt("Type a number", 0, 4);
            UserInterface.ShowMenuOptionMessage(choice);

            switch (choice) {
                case 1:
                    HandleRent(bookLibrary);
                    break;
            }

        }

        private void HandleRent(BookLibrary bookLibrary)
        {
            UserInterface.ShowSearchMenu();
            int choice = Utilities.LerNumeroInt("Type a number", 0, 4);
            UserInterface.ShowSerchOptionMessage(choice);
=======
        public void HandleSession()
        {
            do
            {
                Console.Clear();
                UserInterface.ShowLibraryWelcome();
                UserInterface.ShowLibraryMenu();
                HandleMenuChoice();

                Console.WriteLine("Press 'y' to exit or any other key to do another operation");
            } while (Console.ReadLine().ToLower() != "y");


        }

        public void HandleMenuChoice()
        {
            int choice = Utilities.LerNumeroInt("Type a number", 0, 4);
            Console.Clear();
            UserInterface.ShowMenuOptionMessage(choice);
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e

            switch (choice)
            {
                case 1:
<<<<<<< HEAD
                    string title = Utilities.LerString("Enter the author's name");
                    var resultList = bookLibrary.searchByAuthor(title);
                    UserInterface.showBookList(resultList);

                    string id;
                    do
                    {
                        id = Utilities.LerString("Enter the book ID to rent it");
                        if (bookLibrary.RentBook(id, resultList))
                        {
                            Console.Write("YOU RENTED: ");
                            UserInterface.showBook(bookLibrary.FindBooksByID(id));
                        }
                        else Console.WriteLine("Plese type a valid ID");

                    } while (!bookLibrary.RentBook(id, resultList));

                    break;
                    

            }
=======
                    HandleRent();
                    break;
                case 2:
                    HandleReturn();
                    break;
                default:
                    break;
            }

        }

        private void HandleReturn()
        {
            var rentedBooks = BookLibrary.FindBooksByStatus("RENTED");
            UserInterface.showBookList(rentedBooks);
            ReturnBookLoop(rentedBooks);
        }

        private void HandleRent()
        {
            UserInterface.ShowSearchMenu();
            int choice = Utilities.LerNumeroInt("Type a number or press 0 to exit", -1, 4);
            UserInterface.ShowSerchOptionMessage(choice);

            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    RentByAuthor();
                    break;
                case 2:
                    RentByGenre();  
                    break;
                case 3:
                    RentByTitle();
                    break;
                case 4:
                    Rent();
                    break;
                default:
                    Console.WriteLine("You do not choose a valid option");
                    break;

            }

        }

        private void Rent()
        {
            Console.Clear();
            UserInterface.showBookList(BookLibrary.getTotalBookList());
            RentBookLoop(BookLibrary.getTotalBookList());
        }

        private void RentByAuthor()
        {
            do
            {
                string title = Utilities.LerString("Enter the author's name");
                var authorList = BookLibrary.searchByAuthor(title);
                if (authorList != null)
                {
                    UserInterface.showBookList(authorList);
                    RentBookLoop(authorList);
                    break;
                }

                Console.WriteLine("No books found for the specified author. Please try again.");

            } while (true);
         
        }

        private void RentByGenre()
        {
            do
            {
                string genre = Utilities.LerString("Enter the genre");
                var genreList = BookLibrary.searchByGenre(genre);

                if(genreList != null)
                {
                    UserInterface.showBookList(genreList);
                    RentBookLoop(genreList);
                    return;
                }

                Console.WriteLine("No books found for the specified genre. Please try again.");

            }while(true);
       

           
        }

        private void RentByTitle()
        {
            do { 
            string title = Utilities.LerString("Enter the title");
            var titleList = BookLibrary.searchByTitle(title);

            if (titleList != null)
                {
                    UserInterface.showBookList(titleList);
                    RentBookLoop(titleList);
                }

            Console.WriteLine("No books found for the specified title. Please try again.");

            } while (true);
        }

        private void RentBookLoop(List<Dictionary<string, string>> bookList)
        {
            string id;
            do
            {
                id = Utilities.LerString("Enter the book ID to rent it");

                if (BookLibrary.RentBook(id, bookList))
                {
                    Console.Write("YOU RENTED: ");
                    UserInterface.showBook(BookLibrary.FindBooksByID(id));
                    break;
                }
                else
                {
                    Console.WriteLine("Please type a valid ID");
                }
            } while (true);
        }


        private void ReturnBookLoop(List<Dictionary<string, string>> bookList)
        {
            string id;
            do
            {
                id = Utilities.LerString("Enter the book ID to return it");

                if (BookLibrary.ReturnBook(id, bookList))
                {
                    Console.Write("\nTHANK YOU, YOU RETURNED: ");
                    UserInterface.showBook(BookLibrary.FindBooksByID(id));
                    break;
                }
                else
                {
                    Console.WriteLine("Please type a valid ID");
                }
            } while (true);
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        }
    }
}
