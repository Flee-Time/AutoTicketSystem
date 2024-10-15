using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.DTO
{
    public class RouteListItemDTO
    {
        public string RouteID { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string EmptySeats { get; set; }
        public string Price { get; set; }
        public DateTime Date {  get; set; }
        public string ETA { get; set; }
    }
}
