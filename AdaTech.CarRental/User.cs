using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AdaTech.CarRental
{
    public abstract class User
    {
        private static int lastID = 0;
        protected int idUsur { get; }
        protected string username { get; set; }
        protected string hashPassword { get; set; }
        protected string name { get; set; }

        public User(string username, string password, string name) {
            idUsur = ++lastID;
            this.username = username;
            this.name = name;
            hashPassword = EncryptPassword(password);
        }

        private static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the password to bytes
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Compute the SHA-256 hash
                byte[] hash = sha256.ComputeHash(bytes);

                // Convert the hash back to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2")); // "x2" represents hexadecimal formatting
                }

                return sb.ToString();
            }
        }

        public static void VerifyLogin(string username, string password)
        {
            User user = UserRepository.getUsersList().Find(user => user.username == username && user.hashPassword == EncryptPassword(password);
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
