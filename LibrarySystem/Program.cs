using AdaTech.LibrarySystem;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
<<<<<<< HEAD
        {
           BookLibrary bookLibrary = new BookLibrary();    
           LibraryController controller = new LibraryController();  
           controller.HandleSession(bookLibrary);
       
         
=======
        {  
            LibraryController controller = new LibraryController();
            controller.HandleSession();

>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        }
    }
}
