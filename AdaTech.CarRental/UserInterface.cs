using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace AdaTech.CarRental
{
    public static class UserInterface
    {
        public static void showTitle()
        {
            string carRentalText = FiggleFonts.Standard.Render("Car Rental");
            Console.WriteLine();
        }

        public static void showLoginMenu()
        {
            Console.WriteLine("+===============================+");
            Console.WriteLine("|        * CHOOSE ONE *         |");
            Console.WriteLine("|      1. Login as Client       |");
            Console.WriteLine("|      2. Login as Employee     |");
            Console.WriteLine("|      3. Register              |");
            Console.WriteLine("+===============================|");
        }

        public static void showLoginOption(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("You choose LOGIN AS CLIENT");
                    break;
                case 2:
                    Console.WriteLine("You chose LOGIN AS EMPLOYEE");
                    break;
                case 3:
                    Console.WriteLine("You chose Register");
                    break;
                default:
                    break;
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Welcome to CAR RENTAL\n");

            Console.WriteLine("+===============================+");
            Console.WriteLine("|      * CHOOSE ONE *           |");
            Console.WriteLine("|      1. Find a Vehicle        |");
            Console.WriteLine("|      2. Check reservations    |");
            Console.WriteLine("|      3. Pick up a Vehicle     |");
            Console.WriteLine("|      4. Return Vehicle        |");
            Console.WriteLine("+===============================|");
        }




    }
}
