using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Models
{
    public class OrderHeader
    {
        [Key]
        public int OrderHeader_OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderHeader_CustomerID { get; set; }
    }
}
