using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string MaterialName { get; set; } = string.Empty;
        public int UnitPrice { get; set; }
        public int Stock { get; set; }
        public string Satuan { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
        public string StatusTersedia => IsAvailable ? "Ya" : "Tidak";
    }
}
