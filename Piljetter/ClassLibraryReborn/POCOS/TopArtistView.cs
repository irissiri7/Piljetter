using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryReborn.POCOS
{
    public class TopArtistView
    {
        public int ConcertId { get; set; }
        public string Artist { get; set; }
        public string Scene { get; set; }
        public DateTime Time { get; set; }
        public int PercentageSoldOut { get; set; }
    }
}
