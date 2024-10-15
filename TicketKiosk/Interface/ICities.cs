using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Models;

namespace OBS.Interface
{
    public interface ICities
    {
        public List<Cities> GetCitiesDetails();
        public Cities GetCitiesDetails(string ci);
    }
}
