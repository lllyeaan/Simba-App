using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string NoPolisi { get; set; }
        public string DriverName { get; set; }
        public string NoHP { get; set; }
        public string Display => $"{NoPolisi} - {DriverName}";
    }

}

