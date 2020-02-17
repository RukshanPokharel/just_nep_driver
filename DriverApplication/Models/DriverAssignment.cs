using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DriverApplication.Models
{
    public class DriverAssignment
    {
        private int assignment_id;
        [Column("assignment_id")]
        [Key]
        [JsonIgnore]
        public int Assignment_id { get => assignment_id; set => assignment_id = value; }

        private string auto_assign_type;
        [Column("auto_assign_type")]
        [StringLength(50)]
        public string Auto_assign_type { get => auto_assign_type; set => auto_assign_type = value; }

        private int task_id;            // foregin key from mt_driver_task
        [Column("task_id")]
        public int Task_id { get => task_id; set => task_id = value; }

        private int driver_id;      //foreign key from mt_driver
        [Column("driver_id")]
        public int Driver_id { get => driver_id; set => driver_id = value; }

        private string first_name;
        [Column("first_name")]
        [StringLength(255)]
        public string First_name { get => first_name; set => first_name = value; }

        private string last_name;
        [Column("last_name")]
        [StringLength(255)]
        public string Last_name { get => last_name; set => last_name = value; }

        private string status;
        [Column("status")]
        [StringLength(100)]
        [DefaultValue("pending")]
        public string Status { get => status; set => status = value; }

        private string task_status;
        [Column("task_status")]
        [StringLength(255)]
        public string Task_status { get => task_status; set => task_status = value; }

        private DateTime? date_created;
        [Column("date_created")]
        public DateTime? Date_created { get => date_created; set => date_created = value; }

        private DateTime? date_process;
        [Column("date_process")]
        public DateTime? Date_process { get => date_process; set => date_process = value; }

        private string ip_address;
        [Column("ip_address")]
        [StringLength(50)]
        public string Ip_address { get => ip_address; set => ip_address = value; }



    }
}