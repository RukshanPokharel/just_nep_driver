using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DriverApplication.Models
{
    public class DriverTeam
    {
        private int team_id;
        [Key]
        [JsonIgnore]
        public int Team_id { get => team_id; set => team_id = value; }

        private string user_type;
        [StringLength(100)]
        public string User_type { get => user_type; set => user_type = value; }

        private int user_id;
        [DefaultValue(0)]
        public int User_id { get => user_id; set => user_id = value; }

        private string team_name;
        [StringLength(255)]
        public string Team_name { get => team_name; set => team_name = value; }

        private string location_accuracy;
        [StringLength(50)]
        public string Location_accuracy { get => location_accuracy; set => location_accuracy = value; }

        private string status;
        [StringLength(255)]
        public string Status { get => status; set => status = value; }

        private DateTime? date_created;
        public DateTime? Date_created { get => date_created; set => date_created = value; }

        private DateTime? date_modified;
        public DateTime? Date_modified { get => date_modified; set => date_modified = value; }

        private string ip_address;
        [StringLength(50)]
        public string Ip_address { get => ip_address; set => ip_address = value; }

    }
}