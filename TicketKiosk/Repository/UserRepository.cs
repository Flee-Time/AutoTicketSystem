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
    public class UserRepository : IUsers
    {
        public List<Users> GetUserDetails()
        {
            using (var context = new BusContext())
            {
                try
                {
                    return context.Users.AsNoTracking().ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Users GetUserDetails(string uuid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Users? user = context.Users.AsNoTracking().FirstOrDefault(b => b.Uuid == uuid);
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(uuid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public void AddUser(Users user)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void UpdateUser(Users user)
        {
            using (var context = new BusContext())
            {
                try
                {
                    context.Users.Update(user);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public Users DeleteUser(string uuid)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Users? user = context.Users.Find(uuid);

                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        return user;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(uuid));
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool CheckUser(string uuid)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().Any(e => e.Uuid == uuid);
            }
        }

        public bool CheckGovID(string govid)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().Any(e => e.GovID == govid);
            }
        }

        public bool CheckUsername(string username)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().Any(e => e.Username == username);
            }
        }

        public bool CheckEmail(string email)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().Any(e => e.Email == email);
            }
        }

        public bool CheckPhone(string phone)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().Any(e => e.Phone == phone);
            }
        }

        public Users GetUser(string username, string password)
        {
            using (var context = new BusContext())
            {
                return context.Users.AsNoTracking().FirstOrDefault(e => e.Username == username && e.Password == password);
            }
        }

        public Users GetUserByGovID(string GovID)
        {
            using (var context = new BusContext())
            {
                try
                {
                    Users? user = context.Users.AsNoTracking().FirstOrDefault(b => b.GovID == GovID);
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(GovID));
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
