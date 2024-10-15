using Microsoft.EntityFrameworkCore;
using OBS.Database;
using OBS.Interface;
using OBS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Repository
{
    public class TicketRepository : ITicket
    {
        public List<Ticket> GetTicketDetails()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Ticket.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Ticket GetTicketDetails(string uuid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Ticket? ticket = context.Ticket.AsNoTracking().FirstOrDefault(b => b.TicketID == uuid);
                    if (ticket != null)
                    {
                        return ticket;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(uuid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void AddTicket(Ticket ticket)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Ticket.Add(ticket);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void UpdateTicket(Ticket ticket)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Ticket.Update(ticket);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Ticket DeleteTicket(string uuid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Ticket? ticket = context.Ticket.Find(uuid);

                    if (ticket != null)
                    {
                        context.Ticket.Remove(ticket);
                        context.SaveChanges();
                        return ticket;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(uuid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool CheckTicket(string uuid)
        {
            using (var context = new BusContext())
            {
                return context.Ticket.AsNoTracking().Any(e => e.TicketID == uuid);
            }
        }

        public List<Ticket> GetTicketsFromUserID(string UserID)
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Ticket.AsNoTracking().Where(b => b.TicketUserID == UserID).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
