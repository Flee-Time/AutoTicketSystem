using OBS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OBS.Database;
using OBS.Models;
using System.Security.Cryptography;

namespace OBS.Repository
{
    public class BusRoutesRepository : IBusRoutes
    {
        public List<BusRoutes> GetBusRoutesDetails()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.BusRoutes.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public BusRoutes GetBusRoutesDetails(string ri)
        {
            using (var context = new BusContext())
            {
                try
                {
                    BusRoutes? busRoutes = context.BusRoutes.AsNoTracking().FirstOrDefault(b => b.RouteID == ri);
                    if (busRoutes != null)
                    {
                        return busRoutes;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(ri));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void AddBusRoutes(BusRoutes busRoutes)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.BusRoutes.Add(busRoutes);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void UpdateBusRoutes(BusRoutes busRoutes)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.BusRoutes.Update(busRoutes);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public BusRoutes DeleteBusRoutes(string ri)
        {
            using (var context = new BusContext())
            {
                try
                {
                    BusRoutes? busRoutes = context.BusRoutes.Find(ri);

                    if (busRoutes != null)
                    {
                        context.BusRoutes.Remove(busRoutes);
                        context.SaveChanges();
                        return busRoutes;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(ri));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool CheckBusRoutes(string ri)
        {
            using (var context = new BusContext())
            {
                return context.BusRoutes.AsNoTracking().Any(e => e.RouteID == ri);
            }
        }

        public bool ReserveSeat(int seatNumber, string guid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    BusRoutes? busRoutes = context.BusRoutes.FirstOrDefault(b => b.RouteID == guid);
                    Bus? bus = context.Bus.FirstOrDefault(b => b.BusID == busRoutes.UsedBusID);

                    if (seatNumber > Convert.ToInt32(bus.MaxPassengers))
                    {
                        return false;
                    }

                    if (busRoutes != null)
                    {
                        List<string> rseats = busRoutes.ReservedSeats.Split(',').ToList();
                        foreach (var rseat in rseats)
                        {
                            if (rseat != "")
                            {
                                if (seatNumber == Convert.ToInt32(rseat))
                                {
                                    return false;
                                }
                            }
                        }
                        rseats.Add(Convert.ToString(seatNumber));
                        busRoutes.ReservedSeats = String.Join(',', rseats);
                        context.BusRoutes.Update(busRoutes);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(guid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool RemoveSeat(int seatNumber, string guid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    BusRoutes? busRoutes = context.BusRoutes.FirstOrDefault(b => b.RouteID == guid);
                    Bus? bus = context.Bus.FirstOrDefault(b => b.BusID == busRoutes.UsedBusID);

                    if (seatNumber > Convert.ToInt32(bus.MaxPassengers))
                    {
                        return false;
                    }

                    List<string> Seats = new List<string>();

                    if (busRoutes != null)
                    {
                        Seats = busRoutes.ReservedSeats.Split(',').ToList();
                        List<string> newSeats = new List<string>(Seats);
                        foreach (var seat in Seats)
                        {
                            if (seat != "")
                            {
                                if (seatNumber == Convert.ToUInt32(seat))
                                {
                                    newSeats.Remove(Convert.ToString(seatNumber));
                                }
                            }
                        }

                        busRoutes.ReservedSeats = String.Join(",", newSeats);
                        context.BusRoutes.Update(busRoutes);
                        context.SaveChanges();
                        return true;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(guid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
