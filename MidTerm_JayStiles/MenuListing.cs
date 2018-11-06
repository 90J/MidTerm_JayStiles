using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm_JayStiles
{
    public class MenuListing
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public long CCNumber { get; set; }
        public int CVV { get; set; }
        public DateTime ExpirationDate { get; set; }
        public long RoutingNumber { get; set; }
        public long AccountNumber { get; set; }
    }
}
