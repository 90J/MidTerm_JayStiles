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
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "Menu.csv");
            var fileContents = ReadMenu(fileName);
            double tallyPrice;
            double changeDue;
            double amountPaid;
            double totalDue;
        }
        public double TotalWithTax(double tallyPrice)
        {
            double x = tallyPrice * 1.06;
            return x;
        }


        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }



        public static List<MenuListing> ReadMenu(string fileName)
        {
            var menuListing = new List<MenuListing>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    var tallyPrice = new MenuListing();

                    double itemPrice;
                    if (double.TryParse(values[1], out itemPrice))
                    {
                        tallyPrice.ItemPrice = itemPrice;
                    }

                    menuListing.Add(tallyPrice);

                }
            }
            return menuListing;

        }
    }
}
