using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Models;

namespace OBS.Interface
{
    public interface IBus
    {
        public List<Bus> GetBusDetails();
        public Bus GetBusDetails(string lp);
        public void AddBus(Bus bus);
        public void UpdateBus(Bus bus);
        public Bus DeleteBus(string lp);
        public bool CheckBus(string lp);
        public string GetIDFromPlate(string lp);
    }
}
