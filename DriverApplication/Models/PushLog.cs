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
    public class PushLog
    {
        private int push_id;
        [Column("push_id")]
        [Key]
        [JsonIgnore]
        public int Push_id { get => push_id; set => push_id = value; }

        private string device_platform;
        [Column("device_platform")]
        [StringLength(50)]
        public string Device_platform { get => device_platform; set => device_platform = value; }

        private string device_id;
        [Column("device_id")]
        [StringLength(255)]
        public string Device_id { get => device_id; set => device_id = value; }

        private string push_title;
        [Column("push_title")]
        [StringLength(255)]
        public string Push_title { get => push_title; set => push_title = value; }

        private string push_message;
        [Column("push_message")]
        [StringLength(255)]
        public string Push_message { get => push_message; set => push_message = value; }

        private string push_type;
        [Column("push_type")]
        [StringLength(50)]
        [DefaultValue("task")]
        public string Push_type { get => push_type; set => push_type = value; }

        private string actions;
        [Column("actions")]
        [StringLength(255)]
        public string Actions { get => actions; set => actions = value; }

        private string status;
        [Column("status")]
        [StringLength(255)]
        [DefaultValue("pending")]
        public string Status { get => status; set => status = value; }

        private string json_response;
        [Column("json_response")]
        [StringLength(255)]
        public string Json_response { get => json_response; set => json_response = value; }

        private int order_id;       // foreign key mt_order
        [Column("order_id")]
        public int Order_id { get => order_id; set => order_id = value; }

        private int driver_id;      // foreign key mt_driver
        [Column("driver_id")]
        public int Driver_id { get => driver_id; set => driver_id = value; }

        private int task_id;        // foreign key mt_driver_task
        [Column("task_id")]
        public int Task_id { get => task_id; set => task_id = value; }

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

        private int is_read;
        [Column("is_read")]
        [DefaultValue(2)]
        public int Is_read { get => is_read; set => is_read = value; }

        private int bulk_id;        // foreign key mt_driver_bulk_push
        [Column("bulk_id")]
        public int Bulk_id { get => bulk_id; set => bulk_id = value; }

        private string user_type;
        [Column("user_type")]
        [StringLength(50)]
        public string User_type { get => user_type; set => user_type = value; }

        private int user_id;
        [Column("user_id")]
        [DefaultValue(0)]
        public int User_id { get => user_id; set => user_id = value; }

    }
}