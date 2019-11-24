using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DriverApplication.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        [Required]
        [StringLength(255)]
        public string DriverName { get; set; }
        public string DriverContact { get; set; }

    }   
}