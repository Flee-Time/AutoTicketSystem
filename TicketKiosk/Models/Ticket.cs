using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Models
{
    [Index(nameof(TicketID), IsUnique = true)]
    public class Ticket
    {
        [Key]
        public string TicketID { get; set; }
        [ForeignKey("Uuid")]
        public string TicketUserID { get; set; }
        [ForeignKey("RouteID")]
        public string TicketRouteID { get; set; }
        public string Pnr {  get; set; }
        public int Seat { get; set; }
    }
}
