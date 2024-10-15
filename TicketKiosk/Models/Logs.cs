using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Models
{
    public class Logs
    {
        [Key]
        public int LogID { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public string PCName { get; set; }
        public string Ip { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
