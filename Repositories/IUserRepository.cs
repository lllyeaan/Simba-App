using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialOrderingApp.Models;

namespace MaterialOrderingApp.Repositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        bool IsUsernameTaken(string username);
        User CreateUser(string username, string password, string role, Customer customer = null);
    }
}
