using OBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Interface
{
    public interface ITicket
    {
        public List<Ticket> GetTicketDetails();
        public Ticket GetTicketDetails(string uuid);
        public void AddTicket(Ticket ticket);
        public void UpdateTicket(Ticket ticket);
        public Ticket DeleteTicket(string uuid);
        public bool CheckTicket(string uuid);
        public List<Ticket> GetTicketsFromUserID(string UserID);
    }
}
