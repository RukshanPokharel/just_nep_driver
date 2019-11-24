using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int customerContact { get; set; }
        public string assignedDriver { get; set; }
    }
}