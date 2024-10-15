using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Models
{
    public class BusRoutes
    {
        [Key]
        public string RouteID { get; set; }
        [ForeignKey("BusID")]
        public string UsedBusID { get; set; }
        public DateTime Date { get; set; }
        public string ETA { get; set; }
        public string DepartureLocation { get; set; }
        public string DestinationLocation { get; set; }
        public double Price { get; set; }
        public string ReservedSeats { get; set; }
    }
}
