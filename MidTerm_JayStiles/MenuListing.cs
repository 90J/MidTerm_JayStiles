using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MidTerm_JayStiles
{
    class MenuListing
    {
        public static List<MenuListing> cartList = new List<MenuListing>();

        public string itemNumber;
        public string itemName;
        public string itemCategory;
        public string itemDescription;
        public double itemPrice;
        public double itemQuantity;

        public MenuListing(string itemNumber, string itemName, string itemCategory, string itemDescription, double itemPrice)
        {
            this.ItemNumber = ItemNumber;
            this.ItemName = itemName;
            this.ItemCategory = itemCategory;
            this.ItemDescription = itemDescription;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
        }
        public string ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemCategory { get => itemCategory; set => itemCategory = value; }
        public string ItemDescription { get => ItemDescription; set => ItemDescription = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
        public double ItemQuantity { get => itemQuantity; set => itemQuantity = value; }





        
    }
}
