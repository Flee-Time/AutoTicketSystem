using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Models;

namespace OBS.Interface
{
    public interface IBusRoutes
    {
        public List<BusRoutes> GetBusRoutesDetails();
        public BusRoutes GetBusRoutesDetails(string ri);
        public void AddBusRoutes(BusRoutes busRoutes);
        public void UpdateBusRoutes(BusRoutes busRoutes);
        public BusRoutes DeleteBusRoutes(string ri);
        public bool CheckBusRoutes(string ri);
        public bool ReserveSeat(int seatNumber, string guid);
        public bool RemoveSeat(int seatNumber, string guid);
    }
}
