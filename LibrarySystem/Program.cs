using AdaTech.LibrarySystem;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            LibraryController controller = new LibraryController();
            controller.HandleSession();

        }
    }
}
