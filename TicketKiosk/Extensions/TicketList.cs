using OBS.DTO;
using OBS.Interface;
using OBS.Models;
using OBS.Repository;
using OBS.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Extensions
{
    public class TicketList
    {
        public static List<TicketListItem> drawList(List<Ticket> TList, IBusRoutes _IBusRoutes, int X_Location, int Y_Location)
        {
            List<TicketListItem> TLIList = new List<TicketListItem>();
            int x = 0;

            if (TList.Count == 0)
            {
                TLIList.Clear();
                return TLIList;
            }
            else
            {
                foreach (Ticket ticket in TList)
                {
                    if (_IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID).Date > DateTime.Now)
                    {
                        TicketListItemDTO dto = new TicketListItemDTO
                        {
                            TicketID = ticket.TicketID,
                            Arrival = _IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID).DestinationLocation,
                            Departure = _IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID).DepartureLocation,
                            Date = _IBusRoutes.GetBusRoutesDetails(ticket.TicketRouteID).Date,
                            Seat = Convert.ToString(ticket.Seat),
                            Pnr = ticket.Pnr
                        };

                        var ticketListItem = new TicketListItem(dto);

                        ticketListItem.Location = new Point(X_Location, Y_Location + (ticketListItem.Size.Height * x));
                        ticketListItem.Name = "ticketListItem" + x.ToString();

                        TLIList.Add(ticketListItem);

                        x++;
                    }
                }

                return TLIList;
            }
        }
    }
}
