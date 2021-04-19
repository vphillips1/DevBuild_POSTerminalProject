using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSTerminalProject
{
   public  class ShoppingCart
   {

        public static List<Product> menuItems = new List<Product>();

        public static List<Product> userCart = new List<Product>();

        public static void ListofItems()
        {

            Console.WriteLine("\t Item            \t Category         \t Description           \t\tPrice");
            Console.WriteLine("===============================================================================================");
            for (int i = 0; i < menuItems.Count; i++)
            {

                var item = menuItems.ElementAt(i);
                Console.WriteLine($"{i + 1}\t {item.Name}   \t \t {item.Category} \t \t \t  {item.Description}\t \t\t{item.Price}");
                
            }
        }

        public static void AddUserItems()
        {
            bool keepPurchasing = true;

            while (keepPurchasing)
            {

                int userChoice = 0;
                try
                {
                    Console.WriteLine("Please choose an item you will like to buy. Select from 1 - 12.");
                     userChoice = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {

                    Console.WriteLine("Please enter a valid selection");
                }

                if (userChoice > 0 && userChoice < menuItems.Count + 1)
                {


                        Console.WriteLine($"You have selected: {menuItems[userChoice - 1]}");

                        Console.WriteLine("Please enter the quantity");
                        var userquantity = Int32.Parse(Console.ReadLine());
                        decimal totalPrice = 0;
                        for (int i = 0; i < userquantity; i++)
                        {


                            userCart.Add(menuItems[userChoice - 1]);


                            totalPrice = menuItems[userChoice - 1].Price * userquantity;

                        }

                        // Going to update it and prompt the user to continue adding items
                    //bool repeat = true;
                    //while (repeat)
                    //{
                    //    Console.WriteLine("Would you like to add another item ?");
                    //    string userResponse = Console.ReadLine();

                    //    if (userResponse.Equals("n", StringComparison.OrdinalIgnoreCase))
                    //    {
                    //        repeat = false;



                    //    }
                    //    else if (userResponse.Equals("y", StringComparison.OrdinalIgnoreCase))
                    //    {
                    //        keepPurchasing = true;
                    //        repeat = false;
                    //    }
                    //    else
                    //    {

                    //        Console.WriteLine("Please enter a valid selection");
                    //        repeat = true;

                    //    }

                    //}

                    //The code below was showing all the items in the user's cart
                    //for (int i = 0; i < userCart.Count; i++)
                    //{
                    //    Console.WriteLine($"{userCart[i]}");
                    //}


                        decimal taxtotal = 0.06m;
                        decimal total = 0;
                        decimal grandTotal = 0;


                        total = Register.ProductTotal(menuItems[userChoice - 1].Price, userquantity);

                        Console.WriteLine($"The total price without tax is: {total}");

                        Console.WriteLine($"The tax is {taxtotal}\n");

                        grandTotal = Register.GrandTotal(totalPrice, taxtotal);

                        Console.WriteLine($"The grand total with sale tax is {Math.Round(grandTotal, 2)}\n");
                        Console.WriteLine($"The method of payment is cash only. Please provide your cash amount");
                        var userCash = Decimal.Parse(Console.ReadLine());



                    bool again = true;

                    while (again)
                    {
                      
                        if (userCash >= grandTotal)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Your change is {Math.Round(Register.ChangeBack(userCash, grandTotal), 2)}");

                            Console.WriteLine($"Your receipt:\n {userquantity} {menuItems[userChoice - 1].Name}\n SubTotal: {total}\n Grand Total: {Math.Round(grandTotal, 2)}\n Amount Tendered: {userCash}");
                            again = false;

                        }
                        else if(userCash < grandTotal)
                        {

                            Console.WriteLine($"Sorry, you will need to provide more funds. The grand total with sale tax is {Math.Round(grandTotal, 2)}");
                            Console.WriteLine($" Please re enter your cash amount");
                            userCash = Decimal.Parse(Console.ReadLine());


                          
                            again = true;

                        }
                        else
                        {

                            Console.WriteLine("Please provide cash only");
                            again = true;
                        }





                    }

                    keepPurchasing = false;
                }
                else
                {

                    Console.WriteLine("That is not a valid option. Please try again.");
                    ListofItems();
                    keepPurchasing = true;
                }


                
              

            }
                                                    
                    

        }
                    


   }

                            



}
