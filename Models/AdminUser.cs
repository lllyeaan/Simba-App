using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class AdminUser : User
    {
        public override string GetDisplayRole()
        {
            return "Admin";
        }
    }
}
