using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class MaterialDipilih
    {
        public int Id { get; set; }
        public string MaterialName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Satuan { get; set; }
        //public int Jumlah { get; set; }
    }
}