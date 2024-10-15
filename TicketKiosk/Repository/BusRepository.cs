using OBS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OBS.Database;
using OBS.Models;

namespace OBS.Repository
{
    public class BusRepository : IBus
    {
        public List<Bus> GetBusDetails()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Bus.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Bus GetBusDetails(string lp)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Bus? bus = context.Bus.AsNoTracking().FirstOrDefault(b => b.BusID == lp);
                    if (bus != null)
                    {
                        return bus;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(lp));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void AddBus(Bus bus)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Bus.Add(bus);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void UpdateBus(Bus bus) 
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Bus.Update(bus);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Bus DeleteBus(string lp)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Bus? bus = context.Bus.Find(lp);

                    if (bus != null)
                    {
                        context.Bus.Remove(bus);
                        context.SaveChanges();
                        return bus;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(lp));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool CheckBus(string lp)
        {
            using (var context = new BusContext())
            {
                return context.Bus.AsNoTracking().Any(e => e.LicensePlate == lp);
            }
        }

        public string GetIDFromPlate(string lp)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Bus? bus = context.Bus.AsNoTracking().FirstOrDefault(b => b.LicensePlate == lp);
                    if (bus != null)
                    {
                        return bus.BusID;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(lp));
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
