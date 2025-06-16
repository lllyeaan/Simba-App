using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class CustomerUser : User
    {
        public override string GetDisplayRole()
        {
            return "Customer";
        }
    }
}
