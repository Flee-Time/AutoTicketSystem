using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Models
{
    public class Bus
    {
        [Key]
        public string BusID { get; set; }
        public string LicensePlate { get; set; }
        public string SeatingOrder { get; set; }
        public string MaxPassengers { get; set; }
    }
}
