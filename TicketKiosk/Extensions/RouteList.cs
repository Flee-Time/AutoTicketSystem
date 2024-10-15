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
    public class RouteList
    {
        public static List<RouteListItem> drawList(List<BusRoutes> BList, IBus _IBus, int X_Location, int Y_Location)
        {
            List<RouteListItem> RLIList = new List<RouteListItem>();
            int x = 0;

            if (BList.Count == 0)
            {
                RLIList.Clear();
                return RLIList;
            }
            else
            {
                foreach (BusRoutes busRoute in BList)
                {
                    if (busRoute.Date > DateTime.Now)
                    {
                        RouteListItemDTO dto = new RouteListItemDTO
                        {
                            Price = Convert.ToString(busRoute.Price),
                            Departure = busRoute.DepartureLocation,
                            Arrival = busRoute.DestinationLocation,
                            ETA = busRoute.ETA,
                            EmptySeats = Convert.ToString(Convert.ToInt32(_IBus.GetBusDetails(busRoute.UsedBusID).MaxPassengers) - busRoute.ReservedSeats.Split(',').Length),
                            Date = busRoute.Date,
                            RouteID = busRoute.RouteID
                        };

                        var routeListItem = new RouteListItem(dto);

                        //routeListItem.Size = new Size(675, 120); // Doesnt work when windows scaling is turned on
                        routeListItem.Location = new Point(X_Location, Y_Location + (routeListItem.Size.Height * x));
                        routeListItem.Name = "routeListItem" + x.ToString();

                        RLIList.Add(routeListItem);

                        x++;
                    }
                }

                return RLIList;
            }
        }

        public static void RemoveDynamicallyAddedControls(string controlNamePrefix, Control controlObj)
        {
            // Remove controls based on the specified naming convention
            var controlsToRemove = controlObj.Controls
                .OfType<Control>()
                .Where(c => c.Name.StartsWith(controlNamePrefix))
                .ToList();

            foreach (var control in controlsToRemove)
            {
                controlObj.Controls.Remove(control);
            }
        }
    }
}
