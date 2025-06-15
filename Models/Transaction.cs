using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialOrderingApp.Models
{
    public class Transaction
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public int IdMaterial { get; set; }
        public int quantity { get; set; }
        public decimal subtotal { get; set; }
        public string paymentmethod { get; set; }
        public decimal unitprice { get; set; }

    }
}
