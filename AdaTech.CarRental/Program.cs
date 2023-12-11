namespace AdaTech.CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Client client;
                Employee employee;

                
                Console.Clear();
                UserInterface.showTitle();
                UserInterface.showLoginMenu();
                int option = Utilities.LerNumeroInt("Type your chose", 0, 4);
                UserInterface.showLoginOption(option);

                switch (option) {
                    case 1:
                        client = ClientLogin();
                        UserInterface.ShowClientMenu();
                        break;
                    case 2:
                        employee = EmployeeLogin();
                        break;
                    default:
                        break;
                 }






                Console.WriteLine("Press 'y' continue or any other key to quit");
            } while (Console.ReadLine().ToLower() == "y");
        }


        public static Client ClientLogin()
        {
            string username = Utilities.LerPrimeiraPalavra("USERNAME");
            string password = Utilities.LerPrimeiraPalavra("PASSWORD");

            if (UserRepository.VerifyClientLogin(username, password) != null)
            {
                return (Client)UserRepository.VerifyClientLogin(username, password);
            }

            return null;
        }

        

        public static Employee EmployeeLogin()
        {
            string username = Utilities.LerPrimeiraPalavra("USERNAME");
            string password = Utilities.LerPrimeiraPalavra("PASSWORD");

            if (UserRepository.VerifyEmployeeLogin(username, password) != null)
            {
                return (Employee)UserRepository.VerifyEmployeeLogin(username, password);
            }

            return null;
        }

        


    }
}

