using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class PurchaseHistory
    {
        public int OrderID { get; set; }
        public int NumberOfTickets { get; set; }
        public string Artist { get; set; }
        public string Scene { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }
    }
}
