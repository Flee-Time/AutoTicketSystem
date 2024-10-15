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
    public class LogsRepository : ILogs
    {
        public List<Logs> GetLogs()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Logs.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Logs GetLog(int li)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Logs? log = context.Logs.AsNoTracking().FirstOrDefault(b => b.LogID == li);
                    if (log != null)
                    {
                        return log;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(li));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void AddLog(Logs log)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Logs.Add(log);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
