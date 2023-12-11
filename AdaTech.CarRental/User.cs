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
        public int idUsur { get; }
        public string username { get; set; }
        public string hashPassword { get; set; }
        public string name { get; set; }

        public User(string username, string password, string name) {
            idUsur = ++lastID;
            this.username = username;
            this.name = name;
            hashPassword = EncryptPassword(password);
        }

        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("x2")); 
                }

                return sb.ToString();
            }
        }

        public abstract bool VerifyLogin(string username, string password);




    }
}
