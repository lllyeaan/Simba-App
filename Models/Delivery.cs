using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Delivery
    {
        public int IdOrder { get; set; }
        public string CustomerName { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public string DeliveryStatus { get; set; } = "";

        // Jika ingin tampilkan truk dan driver juga
        public string? TruckNoPolisi { get; set; }
        public string? DriverName { get; set; }

        // Optional: status teks ramah
        public string StatusLabel => DeliveryStatus switch
        {
            "Baru" => "Menunggu",
            "Dikirim" => "Sedang Dikirim",
            "Selesai" => "Terkirim",
            _ => "Tidak Diketahui"
        };
    }
}

