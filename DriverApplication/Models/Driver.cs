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
    public class Driver
    { 
        private int driver_id;
        [Key]
        [JsonIgnore]
        public int Driver_id { get => driver_id; set => driver_id = value; }

        
        private string user_type;
        [StringLength(50)]
        public string User_type { get => user_type; set => user_type = value; }

        
        private int user_id;
        [DefaultValue(0)]
        public int User_id { get => user_id; set => user_id = value; }

        
        private bool on_duty;
        [DefaultValue(true)]
        public bool On_duty { get => on_duty; set => on_duty = value; }

        //[Required]      // indicates that this property should not be null
        
        private string first_name;
        [StringLength(255)]
        public string First_name { get => first_name; set => first_name = value; }

       
        private string last_name;
        [StringLength(255)]
        public string Last_name { get => last_name; set => last_name = value; }

        
        private string email;
        [StringLength(100)]
        public string Email { get => email; set => email = value; }

        
        private string phone;
        [StringLength(20)]
        public string Phone { get => phone; set => phone = value; }

        
        private string username;
        [StringLength(100)]
        public string Username { get => username; set => username = value; }

        
        private string password;
        [StringLength(100)]
        [JsonIgnore]
        public string Password { get => password; set => password = value; }

        [ForeignKey("team_id")]
        private DriverTeam DriverTeam;
        public DriverTeam DriverTeam1 { get => DriverTeam; set => DriverTeam = value; }
        private int team_id;
        public int Team_id { get => team_id; set => team_id = value; }

        
        private string transport_type_id;
        [StringLength(50)]
        public string Transport_type_id { get => transport_type_id; set => transport_type_id = value; }

        
        private string transport_description;
        [StringLength(255)]
        public string Transport_description { get => transport_description; set => transport_description = value; }

        
        private string licence_plate;
        [StringLength(255)]
        public string Licence_plate { get => licence_plate; set => licence_plate = value; }

        
        private string color;
        [StringLength(255)]
        public string Color { get => color; set => color = value; }

        
        private string status;
        [StringLength(255)]
        [DefaultValue("active")]
        public string Status { get => status; set => status = value; }

        private DateTime? date_created;
        public DateTime? Date_created { get => date_created; set => date_created = value; }

        private DateTime? date_modified;
        public DateTime? Date_modified { get => date_modified; set => date_modified = value; }

        private DateTime? last_login;
        public DateTime? Last_login { get => last_login; set => last_login = value; }

        
        private int last_online;
        [DefaultValue(0)]
        public int Last_online { get => last_online; set => last_online = value; }

        private string location_address;   //text
        public string Location_address { get => location_address; set => location_address = value; }

        
        private string location_lat;
        [StringLength(50)]
        public string Location_lat { get => location_lat; set => location_lat = value; }

        
        private string location_lng;
        [StringLength(50)]
        public string Location_lng { get => location_lng; set => location_lng = value; }

        
        private string ip_address;
        [StringLength(50)]
        public string Ip_address { get => ip_address; set => ip_address = value; }

        
        private string forgot_pass_code;
        [StringLength(10)]
        public string Forgot_pass_code { get => forgot_pass_code; set => forgot_pass_code = value; }

        
        private string token;
        [StringLength(255)]
        public string Token { get => token; set => token = value; }

        private string device_id;   //text
        public string Device_id { get => device_id; set => device_id = value; }

        
        private string device_platform;
        [StringLength(50)]
        [DefaultValue("Android")]
        public string Device_platform { get => device_platform; set => device_platform = value; }

        
        private bool enabled_push;
        [DefaultValue(true)]
        public bool Enabled_push { get => enabled_push; set => enabled_push = value; }

        
        private string profile_photo;
        [StringLength(255)]
        public string Profile_photo { get => profile_photo; set => profile_photo = value; }

        
        private int is_signup;
        [DefaultValue(2)]
        public int Is_signup { get => is_signup; set => is_signup = value; }

        
        private string app_version;
        [StringLength(14)]
        public string App_version { get => app_version; set => app_version = value; }

       
        private string last_onduty;
        [StringLength(50)]
        public string Last_onduty { get => last_onduty; set => last_onduty = value; }
    }
}