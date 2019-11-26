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
        public int Team_id { get => team_id; set => team_id = value; }

        [StringLength(100)]
        private string user_type;
        public string User_type { get => user_type; set => user_type = value; }

        [DefaultValue(0)]
        private int user_id;
        public int User_id { get => user_id; set => user_id = value; }

        [StringLength(255)]
        private string team_name;
        public string Team_name { get => team_name; set => team_name = value; }

        [StringLength(50)]
        private string location_accuracy;
        public string Location_accuracy { get => location_accuracy; set => location_accuracy = value; }

        [StringLength(255)]
        private string status;
        public string Status { get => status; set => status = value; }

        private DateTime? date_created;
        public DateTime? Date_created { get => date_created; set => date_created = value; }

        private DateTime? date_modified;
        public DateTime? Date_modified { get => date_modified; set => date_modified = value; }

        [StringLength(50)]
        private string ip_address;
        public string Ip_address { get => ip_address; set => ip_address = value; }

    }
}