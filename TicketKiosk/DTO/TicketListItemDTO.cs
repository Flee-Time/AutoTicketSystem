using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.DTO
{
    public class TicketListItemDTO
    {
        public string TicketID { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string Pnr { get; set; }
        public string Seat { get; set; }
        public DateTime Date {  get; set; }
    }
}
