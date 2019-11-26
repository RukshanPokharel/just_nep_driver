using DriverApplication.Models;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DriverApplication.Repositories
{
    public class DriverRepository : RepositoryBase<Driver>, IDriverRepository
    {
        public DriverRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Driver GetDriverByName(string driverName)
        {
            var driver = this.DbContext.mt_driver.Where(c => c.First_name == driverName).FirstOrDefault();

            return driver;

        }

        public string UpdateDriver(Driver driver)
        {
            
            var driverInDb = this.DbContext.mt_driver.Where(c => c.Driver_id == driver.Driver_id).Single<Driver>();

            driverInDb.Driver_id = driver.Driver_id;
            driverInDb.User_type = driver.User_type;
            driverInDb.User_id = driver.User_id;
            driverInDb.On_duty = driver.On_duty;
            driverInDb.First_name = driver.First_name;
            driverInDb.Last_name = driver.Last_name;
            driverInDb.Email = driver.Email;
            driverInDb.Phone = driver.Phone;
            driverInDb.Username = driver.Username;
            driverInDb.Password = driver.Password;
            driverInDb.DriverTeam1 = driver.DriverTeam1;
            driverInDb.Team_id = driver.Team_id;
            driverInDb.Transport_type_id = driver.Transport_type_id;
            driverInDb.Transport_description = driver.Transport_description;
            driverInDb.Licence_plate = driver.Licence_plate;
            driverInDb.Color = driver.Color;
            driverInDb.Status = driver.Status;
            driverInDb.Date_created = driver.Date_created;
            driverInDb.Date_modified = driver.Date_modified;
            driverInDb.Last_login = driver.Last_login;
            driverInDb.Last_online = driver.Last_online;
            driverInDb.Location_address = driver.Location_address;
            driverInDb.Location_lat = driver.Location_lat;
            driverInDb.Location_lng = driver.Location_lng;
            driverInDb.Ip_address = driver.Ip_address;
            driverInDb.Forgot_pass_code = driver.Forgot_pass_code;
            driverInDb.Token = driver.Token;
            driverInDb.Device_id = driver.Device_id;
            driverInDb.Device_platform = driver.Device_platform;
            driverInDb.Enabled_push = driver.Enabled_push;
            driverInDb.Profile_photo = driver.Profile_photo;
            driverInDb.Is_signup = driver.Is_signup;
            driverInDb.App_version = driver.App_version;
            driverInDb.Last_onduty = driver.Last_onduty;
            
            this.DbContext.Entry(driverInDb).State = System.Data.Entity.EntityState.Modified;
            this.DbContext.SaveChanges();
            return "Hey!! Shady your Driver Data Updated Successfully...";
        }
    }
}