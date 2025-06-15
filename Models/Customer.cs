using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Customer
    {
        public int Id_Customer { get; set; }
        public int Id_User { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Provinsi { get; set; }
        public string Kabupaten { get; set; }
        public string Kecamatan { get; set; }
        public int? IdDesa { get; set; }
        public string Jalan { get; set; }
        public string AlamatDeskripsi { get; set; } 
    }
}
