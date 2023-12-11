using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.CarRental
{
    public static class UserRepository
    {

        public static List<User> usersList = new List<User>()
        {
            new Employee("isabelamendes", "12345", "Isabela Mendes", JobTitle.Manager),
            new Client(PaymentMethod.Cash , "matheusvidal", "12345", "Matheus Vidal", "ABCD1234")
        };

        public static List<User> getUsersList()
        {
            return usersList;
        }

        public static void VerifyLogin(string username, string password)
        {
            User user = usersList.Find(user => user.username == username && user.hashPassword == EncryptPassword(password);
            if (user != null)
            {
                if (user is Employee)
                {
                    // É um Employee
                    Employee employee = user as Employee;
                    // Faça algo com o objeto Employee se necessário
                    Console.WriteLine($"Logged in as Employee: {employee.username}");
                }
                else if (user is Client)
                {
                    // É um Client
                    Client client = user as Client;
                    // Faça algo com o objeto Client se necessário
                    Console.WriteLine($"Logged in as Client: {client.username}");
                }

                return false;
            }

        }
}
