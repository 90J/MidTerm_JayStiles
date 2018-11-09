using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MidTerm_JayStiles
{
    class Program
    {
        public static void Main(string[] args)
        {


            List<MenuListing> menuListings = new List<MenuListing>();
            {
                menuListings.Add(new MenuListing(1, "Apple", "Fruit", "It's red", "Tree", 2.99m));
                menuListings.Add(new MenuListing(2, "Pear", "Fruit", "Not red, mostly", "Tree", 3.99m));
                menuListings.Add(new MenuListing(3, "Tomoato", "Fruit", "Red, unless green", "Plant", 1.99m));
                menuListings.Add(new MenuListing(4, "Corn", "Vegetable", "On the cob", "Plant", .99m));
                menuListings.Add(new MenuListing(5, "Carrot", "Vegetable", "orange-ish", "Root", 1.59m));
                menuListings.Add(new MenuListing(1, "Strawberry", "Fruit", "It's red", "Plant", 2.99m));
                menuListings.Add(new MenuListing(2, "Banana", "Fruit", "Not red, Ever", "Tree", 3.99m));
                menuListings.Add(new MenuListing(3, "Potato", "Vegetable", "Brown", "Root", 1.99m));
                menuListings.Add(new MenuListing(4, "Okra", "Vegetable", "Green", "Plant", .99m));
                menuListings.Add(new MenuListing(5, "Brocolli", "Vegetable", "Green", "Plant", 1.59m));
                menuListings.Add(new MenuListing(4, "Beans", "Vegetable", "Green-ish", "Plant", .99m));
                menuListings.Add(new MenuListing(5, "Orange", "Fruit", "orange-ish", "Tree", 4.59m));
            }

            
            //initial welcome
            Console.WriteLine("Welcome to the store");
            //send to method to buy crap

            PurchaseItems(menuListings);
            PaymentType(menuListings);
            DoTheMaths(menuListings);
        }
        //method to buy crap
        public static void PurchaseItems(List<MenuListing> menuListings)
        {

            //keep buying crap
            bool keepGoing = true;
            while (keepGoing)
            {

                //adding crap
                bool placingOrder = true;

                while(placingOrder)
                {
                    string itemChoice = ChooseProduct(menuListings);
                    List<MenuListing> subList = menuListings;

                    //check if list is null.  If null, ask user if they want to shop or quit
                    if (subList[0] == null)
                    {
                        Console.WriteLine("Nothing added, do you wish to quit? (y/n): ");
                        string quitRequest = Console.ReadLine(); 
                        if(quitRequest == "y")
                        {
                            Console.WriteLine("Goodbye");
                            Environment.Exit(0);

                        }
                        else
                        {
                            placingOrder = false;
                            
                        }
                    }
                    //else, use method to add together prices within subList(send subList down in parameter)
                    else
                    {
                        placingOrder = false;
                    }
                }
                keepGoing = false;
                return;
            }
        }

        public static string ChooseProduct(List<MenuListing> menuListings)
        {
           
            while(true)
            {
                //ShowMenu(menuListings);

                bool itemOrder = true;

                while(itemOrder)
                {
                    List<MenuListing> subMenuListing = new List<MenuListing>();
                    BuyMore:
                    ShowMenu(menuListings);

                    Console.WriteLine("Enter the number for the item that you wish to purchase (1-12)");
                    Console.Write("Or type the following: (checkout), (quit): ");
                    string menuChoice = Console.ReadLine().ToLower();



                    if (menuChoice == "quit")
                    {
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(); 
                        Environment.Exit(0);
                    }
                    else if (menuChoice == "checkout")
                    {
                        menuChoice = "false";
                        PaymentType(menuListings);
                        return menuChoice;//INSTEAD RETURN SUBLIST
                    }
                    else if (Convert.ToInt32(menuChoice) > 0 && Convert.ToInt32(menuChoice) < 13)
                    {

                        foreach (MenuListing subList in menuListings)
                        {
                            if (Convert.ToInt32(menuChoice) == subList.ItemNumber)
                            {
                                //broken here, not adding the the submenu
                                //subMenuListing.Add(subList);
                                subMenuListing.AddRange(menuListings);
                            }
                        }
                        Console.Clear();
                        goto BuyMore;                                                                                
                        
                    }
                    else
                    {
                        Console.WriteLine("Please verify your entry.");
                        continue;
                    }
                }
            }
        }


        public static void ShowMenu(List<MenuListing> menuListings)
        {
            //print the items on the menu
            //add menu optios as well
            Console.WriteLine("=================================================");
            Console.WriteLine("Number=====Title========Description=========Price");
            Console.WriteLine("=================================================");


            foreach (MenuListing item in menuListings)
            {
                Console.WriteLine($"{Convert.ToString(item.ItemNumber)} {item.ItemName}  {item.ItemDescription}   {item.ItemPrice}");
            }
            
        }
        public static void PaymentType(List<MenuListing> menuListings)
        {
            //get type of payment


                Console.WriteLine("Enter your preferred payment type");
                Console.WriteLine("Select from the following");
                Console.WriteLine("(check), (credit), (cash)");
                string paymentType = Console.ReadLine().ToLower();
                if (paymentType == "check")
                {
                    Console.WriteLine("please enter routing number: ");
                    string cRouting = Console.ReadLine(); 

                    Console.WriteLine("please enter account number: ");
                    string cAccount = Console.ReadLine(); 

                    Console.WriteLine("please enter check number: ");
                    string cNumber = Console.ReadLine();

                Console.WriteLine($"You are paying by Check.");
                Console.WriteLine($"Check number: {cNumber}");

                DoTheMaths(menuListings);

                return;
                
                    
                }
                else if (paymentType == "credit")
                {
                    Console.WriteLine("please enter 16 digit card number: ");
                    string ccNumber = Console.ReadLine(); 

                    Console.WriteLine("please enter expration date (MM/YYYY): ");
                    string ccExpiration = Console.ReadLine(); 

                    Console.WriteLine("please enter CVV number found on the back of your card: ");
                    string ccCVV = Console.ReadLine();

                Console.WriteLine("You are paying by credit card.");
                Console.WriteLine($"Credit card number: {ccNumber}");

                DoTheMaths(menuListings);


                return;

                }


            
        }
        public static void Receipt(List<MenuListing> menuListings)
        {
            //spit out receipt with list of items, quantities, prices, taxes and total

        }
        public static void DoTheMaths(List<MenuListing> subMenuListings)
        {

            foreach (MenuListing menuListing in subMenuListings)
            {


                decimal runningTotal = 0.00m;

                runningTotal = menuListing.ItemPrice + runningTotal;
                decimal totalWithTax = runningTotal * 1.06m;


                totalWithTax = runningTotal * 1.06m;
                Console.WriteLine($"Total due is: ${totalWithTax}");
                Console.WriteLine("PLease enter the amount you are paying: ");
                decimal amountPaid = Convert.ToDecimal(Console.ReadLine());
            
                Console.WriteLine(menuListing.ItemName, menuListing.ItemPrice);
                Console.WriteLine($"Your change is: {amountPaid - totalWithTax}");
                Console.ReadKey();

                return;
            }
        }
    }
}

