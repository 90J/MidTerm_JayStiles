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

        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public string ItemDescription { get; set; }
        public string ItemPlatform { get; set; }
        public decimal ItemPrice { get; set; }


        public MenuListing(int itemNumber, string itemName, string itemCategory, string itemDescription, string itemPlatform, decimal itemPrice)
        {
            this.ItemNumber = itemNumber;
            this.ItemName = itemName;
            this.ItemCategory = itemCategory;
            this.ItemDescription = itemDescription;
            this.ItemPlatform = ItemPlatform;
            this.ItemPrice = itemPrice;
        }


        
    }
}
