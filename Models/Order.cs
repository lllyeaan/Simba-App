using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Order
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryStatus { get; set; }
        public string CustomerName { get; set; }
        public string Alamat { get; set; }
        public decimal Total { get; set; }
    }
}
