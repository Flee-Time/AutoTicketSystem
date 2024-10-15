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
    public class CitiesRepository : ICities
    {
        public List<Cities> GetCitiesDetails()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Cities.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Cities GetCitiesDetails(string ci)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Cities? cities = context.Cities.AsNoTracking().FirstOrDefault(b => b.CityID == ci);
                    if (cities != null)
                    {
                        return cities;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(ci));
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
