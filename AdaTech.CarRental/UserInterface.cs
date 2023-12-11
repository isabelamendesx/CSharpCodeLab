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
            Console.WriteLine("|      1. Login                 |");
            Console.WriteLine("|      2. Register              |");
            Console.WriteLine("+===============================|");
        }

        public static void showLoginOption(int option)
        {

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
