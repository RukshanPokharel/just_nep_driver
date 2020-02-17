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
    public class BulkPush
    {
        private int bulk_id;
        [Column("bulk_id")]
        [Key]
        [JsonIgnore]
        public int Bulk_id { get => bulk_id; set => bulk_id = value; }

        private string push_title;
        [Column("push_title")]
        [StringLength(255)]
        public string Push_title { get => push_title; set => push_title = value; }

        private string push_message;
        [Column("push_message")]
        public string Push_message { get => push_message; set => push_message = value; }

        private string status;
        [Column("status")]
        [StringLength(255)]
        [DefaultValue("pending")]
        public string Status { get => status; set => status = value; }

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

        private int team_id;        //foreign key mt_driver_team
        [Column("team_id")]
        [DefaultValue(0)]   
        public int Team_id { get => team_id; set => team_id = value; }

        private string user_type;
        [Column("user_type")]
        [StringLength(50)]
        public string User_type { get => user_type; set => user_type = value; }

        private int user_id;
        [Column("user_id")]
        public int User_id { get => user_id; set => user_id = value; }

    }
}