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
    public class DriverTask
    {
        private int task_id;
        [Column("task_id")]
        [Key]
        [JsonIgnore]
        public int Task_id { get => task_id; set => task_id = value; }

        private int order_id;       //foregin key of order table mt_order
        [Column("order_id")]
        [DefaultValue(0)]
        public int Order_id { get => order_id; set => order_id = value; }

        private string user_type;
        [Column("user_type")]
        [StringLength(100)]
        public string User_type { get => user_type; set => user_type = value; }

        private int user_id;
        [Column("user_id")]
        [DefaultValue(0)]
        public int User_id { get => user_id; set => user_id = value; }

        private string task_description;
        [Column("task_description")]
        [StringLength(255)]
        public string Task_description { get => task_description; set => task_description = value; }

        private string trans_type;
        [Column("trans_type")]
        [StringLength(255)]
        public string Trans_type { get => trans_type; set => trans_type = value; }

        private string contact_number;
        [Column("contact_number")]
        [StringLength(50)]
        public string Contact_number { get => contact_number; set => contact_number = value; }

        private string email_address;
        [Column("email_address")]
        [StringLength(200)]
        public string Email_address { get => email_address; set => email_address = value; }

        private string customer_name;
        [Column("customer_name")]
        [StringLength(255)]
        public string Customer_name { get => customer_name; set => customer_name = value; }

        private DateTime? delivery_date;
        [Column("delivery_date")]
        public DateTime? Delivery_date { get => delivery_date; set => delivery_date = value; }

        private string delivery_address;
        [Column("delivery_address")]
        [StringLength(255)]
        public string Delivery_address { get => delivery_address; set => delivery_address = value; }

        private int team_id;    //foreign key mt_driver_team
        [Column("team_id")]
        public int Team_id { get => team_id; set => team_id = value; }

        private int driver_id;  //foreign key mt_driver
        [Column("driver_id")]
        public int Driver_id { get => driver_id; set => driver_id = value; }

        private string task_lat;
        [Column("task_lat")]
        [StringLength(50)]
        public string Task_lat { get => task_lat; set => task_lat = value; }

        private string task_lng;
        [Column("task_lng")]
        [StringLength(50)]
        public string Task_lng { get => task_lng; set => task_lng = value; }

        private string customer_signature;
        [Column("customer_signature")]
        [StringLength(255)]
        public string Customer_signature { get => customer_signature; set => customer_signature = value; }

        private string status;
        [Column("status")]
        [StringLength(255)]
        [DefaultValue("unassigned")]
        public string Status { get => status; set => status = value; }

        private DateTime? date_created;
        [Column("date_created")]
        public DateTime? Date_created { get => date_created; set => date_created = value; }

        private DateTime? date_modified;
        [Column("date_modified")]
        public DateTime? Date_modified { get => date_modified; set => date_modified = value; }

        private string ip_address;
        [Column("ip_address")]
        [StringLength(50)]
        public string Ip_address { get => ip_address; set => ip_address = value; }

        private string auto_assign_type;
        [Column("auto_assign_type")]
        [StringLength(50)]
        public string Auto_assign_type { get => auto_assign_type; set => auto_assign_type = value; }

        private DateTime? assign_started;
        [Column("assign_started")]
        public DateTime? Assign_started { get => assign_started; set => assign_started = value; }

        private string assignment_status;
        [Column("assignment_status")]
        [StringLength(255)]
        public string Assignment_status { get => assignment_status; set => assignment_status = value; }

        private int dropoff_merchant;
        [Column("dropoff_merchant")]
        [DefaultValue(0)]
        public int Dropoff_merchant { get => dropoff_merchant; set => dropoff_merchant = value; }

        private string dropoff_contact_name;
        [Column("dropoff_contact_name")]
        [StringLength(255)]
        public string Dropoff_contact_name { get => dropoff_contact_name; set => dropoff_contact_name = value; }

        private string dropoff_contact_number;
        [Column("dropoff_contact_number")]
        [StringLength(20)]
        public string Dropoff_contact_number { get => dropoff_contact_number; set => dropoff_contact_number = value; }

        private string drop_address;
        [Column("drop_address")]
        [StringLength(255)]
        public string Drop_address { get => drop_address; set => drop_address = value; }

        private string dropoff_lat;
        [Column("dropoff_lat")]
        [StringLength(30)]
        public string Dropoff_lat { get => dropoff_lat; set => dropoff_lat = value; }

        private string dropoff_lng;
        [Column("dropoff_lng")]
        [StringLength(30)]
        public string Dropoff_lng { get => dropoff_lng; set => dropoff_lng = value; }

        private string recipient_name;
        [Column("recipient_name")]
        [StringLength(255)]
        public string Recipient_name { get => recipient_name; set => recipient_name = value; }

        private int critical;
        [Column("critical")]
        [DefaultValue(1)]
        public int Critical { get => critical; set => critical = value; }

    }
}