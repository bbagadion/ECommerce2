using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce2.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string Customer_FName { get; set; }
        public string Customer_LName { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_PhoneNum { get; set; }
    }
}
