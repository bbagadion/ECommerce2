using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetail_OrderID{ get; set; }
        public int OrderDetail_SalesOrderDetailID { get; set; }
        public int ProductID { get; set; }
        public double Tax { get; set; }
        public double SubTotal { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
