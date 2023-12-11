using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.LibrarySystem
{
    internal class LibraryController
    {
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

            switch (choice)
            {
                case 1:
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
        }
    }
}
