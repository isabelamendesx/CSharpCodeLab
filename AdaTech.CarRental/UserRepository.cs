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

        

        public static User VerifyClientLogin(string username, string password)
        {
            return usersList.Find(user => user is Client && user.VerifyLogin(username, password));
        }

        public static User VerifyEmployeeLogin(string username, string password)
        {
            return usersList.Find(user => user is Employee && user.VerifyLogin(username, password));
        }


    }
}


