namespace AdaTech.CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.cl
                UserInterface.showTitle();
                UserInterface.showLoginMenu();
                int option = Utilities.LerNumeroInt("Type your chose", 0, 4);
                UserInterface.showLoginOption(option)
                
                


            } while (true);
        }

        public static void handleLoginMenu(int option)
        {
            switch (option)
            {
                case 1:
                    ClientLogin(); 
                    break;


            }
        }

        public static void ClientLogin()
        {
            Console.Write("USERNAME: ");
            string username = Console.Read();
            Console.Write("PASSWORD: ");
            string password = Console.Read();
            UserRepository.VerifyLogin(username, password);
        }


    }
}
