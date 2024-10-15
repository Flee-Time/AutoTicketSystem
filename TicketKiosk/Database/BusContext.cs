using Microsoft.EntityFrameworkCore;
using OBS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OBS.Extensions;
using System.Reflection.Metadata;

namespace OBS.Database
{
    public class BusContext : DbContext
    {
        public DbSet<Bus> Bus { get; set; }
        public DbSet<BusRoutes> BusRoutes { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Logs> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["RemoteDatabase"].ConnectionString);
        }
    }
}
