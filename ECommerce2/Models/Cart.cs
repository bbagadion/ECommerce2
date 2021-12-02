using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Models
{
    public class Cart
    {
        [Key]
        public int Cart_CustomerID { get; set; }
        public int CartID { get; set; }
        public string ProdName { get; set; }
        public string Quantity { get; set; }
        public double Subtotal { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
    }
}
