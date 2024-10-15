using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OBS.Models;

namespace OBS.Interface
{
    public interface IUsers
    {
        public List<Users> GetUserDetails();
        public Users GetUserDetails(string uuid);
        public void AddUser(Users user);
        public void UpdateUser(Users user);
        public Users DeleteUser(string uuid);
        public bool CheckUser(string uuid);
        public bool CheckGovID(string govid);
        public bool CheckUsername(string username);
        public bool CheckEmail(string email);
        public bool CheckPhone(string phone);
        public Users GetUser(string username, string password);
        public Users GetUserByGovID(string GovID);
    }
}
