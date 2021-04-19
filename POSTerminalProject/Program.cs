using System;
using System.Collections.Generic;
using System.Linq;

namespace POSTerminalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart.menuItems.Add(new Product("milk", "dairy", "per gallon", 2.29m));
            ShoppingCart.menuItems.Add(new Product("apple", "fruit", "per pound", 2.25m));
            ShoppingCart.menuItems.Add(new Product("bread", "bakery", "per loaf", 1.99m));
            ShoppingCart.menuItems.Add(new Product("cake", "bakery", "per 5 cake", 8.99m));
            ShoppingCart.menuItems.Add(new Product("icecream", "frozen desserts", "per pint", 4.50m));
            ShoppingCart.menuItems.Add(new Product("lettuce", "vegetables", "per 12oz bag", 1.80m));
            ShoppingCart.menuItems.Add(new Product("ribeye steak", "meats", "per pound", 11.25m));
            ShoppingCart.menuItems.Add(new Product("pork belly strips", "meats", "per 5lbs", 24.00m));
            ShoppingCart.menuItems.Add(new Product("dragon fruit", "fruit", "per pound", 4.00m));
            ShoppingCart.menuItems.Add(new Product("unsalted butter", "dairy", "per pound", 4.99m));
            ShoppingCart.menuItems.Add(new Product("granola", "pantry", "per 12oz", 4.99m));
            ShoppingCart.menuItems.Add(new Product("kale", "vegetables", "per pound", 3.99m));


           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to V's Grocery Store!\n");

            bool again = true;

            while (again)
            {
                ShoppingCart.ListofItems();
                Console.WriteLine("");
                ShoppingCart.AddUserItems();

                again = ContinuePurchasing();
            }


        }


        public static bool ContinuePurchasing()
        {
            bool invalidInput = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Would you like to purchase another item ? (y/n) ");
                string userInput = Console.ReadLine().ToLower();


                if (userInput == "y" || userInput == "yes")
                {

                    return true;
                }
                else if (userInput == "n" || userInput == "no")
                {

                    Console.WriteLine("Thank you! Have a great day!");
                    return false;
                }
                else
                {
                    Console.WriteLine("That is not a valid selection");
                }

            } while (invalidInput);

            return true;
        }



    }
}
