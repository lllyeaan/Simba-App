using MaterialOrderingApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public abstract class User
    {

        public int IdCustomer { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Provinsi { get; set; }
        public string Kabupaten { get; set; }
        public string Kecamatan { get; set; }
        public string Jalan { get; set; }
        public int Id { get; set; }
        public abstract string GetDisplayRole();

    }

}

