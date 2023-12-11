using AdaTech.LibrarySystem;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BookLibrary bookLibrary = new BookLibrary();    
           LibraryController controller = new LibraryController();  
           controller.HandleSession(bookLibrary);
       
         
        }
    }
}
