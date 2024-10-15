using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBS.Models
{
    [Index(nameof(GovID), IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Phone), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Users
    {
        [Key]
        public string Uuid { get; set; } // GUID
        public string GovID { get; set; } // TC Kimlik
        public string Username { get; set; }
        public string Password { get; set; } // SHA256
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AuthorityLevel { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set;}
    }
}
