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
        static void Main(string[] args)
        {
            //initial welcome
            Console.WriteLine("welcome to store");
            

            //send to method to buy crap
            PurchaseItems();

        }
        //method to buy crap
        public static void PurchaseItems()
        {
            //keep buying crap
            bool keepGoing = true;

            while (keepGoing)
            {
                double runningTotal = 0;

                //adding crap
                bool placingOrder = true;

                while(placingOrder)
                {
                    string itemChoice = ChooseProduct();
                }
            }
        }
        public static string ChooseProduct()
        {
            
        }

        public static void ShowMenu()
        {

        }
        public static string PaymentType()
        {

        }
        public static void Receipt()
        {

        }
    }
}
