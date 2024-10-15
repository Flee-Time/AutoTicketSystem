using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Models;

namespace OBS.Interface
{
    public interface ILogs
    {
        public List<Logs> GetLogs();
        public Logs GetLog(int li);
        public void AddLog(Logs log);
    }
}
