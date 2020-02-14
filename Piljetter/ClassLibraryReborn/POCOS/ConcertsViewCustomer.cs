using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ConcertsView
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Artist { get; set; }
        public string Scene { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Decimal TicketPrice { get; set; }
        public int AvailableTickets { get; set; }

    }
}
