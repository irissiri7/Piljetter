using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConcertsViewAdmin
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Artist { get; set; }
        public string Scene { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int SoldTickets { get; set; }
        public decimal Expense { get; set; }
        public decimal Earnings { get; set; }
        public decimal TotalRevenue { get; set; }

    }
}
