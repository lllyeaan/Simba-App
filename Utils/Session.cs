using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialOrderingApp.Models;

namespace MaterialOrderingApp.Utils
{
    public static class UserManager
    {
        public static User ActiveUser { get; set; }

        public static void LoginUser(User user)
        {
            ActiveUser = user;
        }

        public static void LogoutUser()
        {
            ActiveUser = null;
        }
    }
}
