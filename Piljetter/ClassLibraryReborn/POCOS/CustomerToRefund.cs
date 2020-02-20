using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class CustomerToRefund
    {
        public int CustomerId{ get; set; }
        public int NumberOfTickets { get; set; }
        public decimal TicketPriceAtPurchase { get; set; }
    }
}
