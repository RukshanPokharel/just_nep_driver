using DriverApplication.Models;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Repositories
{
    public class DriverTasksRepository : RepositoryBase<DriverTask>, IDriverTasksRepository
    {
        public DriverTasksRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public string UpdateDriverTask(DriverTask driverTask)
        {

            var driverTaskInDb = this.DbContext.mt_driver_task.Where(c => c.Task_id == driverTask.Task_id).Single<DriverTask>();

            driverTaskInDb.Task_id = driverTask.Task_id;
            driverTaskInDb.Order_id = driverTask.Order_id;
            driverTaskInDb.User_type = driverTask.User_type;
            driverTaskInDb.User_id = driverTask.User_id;
            driverTaskInDb.Task_description = driverTask.Task_description;
            driverTaskInDb.Trans_type = driverTask.Trans_type;
            driverTaskInDb.Contact_number = driverTask.Contact_number;
            driverTaskInDb.Email_address = driverTask.Email_address;
            driverTaskInDb.Customer_name = driverTask.Customer_name;
            driverTaskInDb.Delivery_date = driverTask.Delivery_date;
            driverTaskInDb.Delivery_address = driverTask.Delivery_address;
            driverTaskInDb.Team_id = driverTask.Team_id;
            driverTaskInDb.Driver_id = driverTask.Driver_id;
            driverTaskInDb.Task_lat = driverTask.Task_lat;
            driverTaskInDb.Task_lng = driverTask.Task_lng;
            driverTaskInDb.Customer_signature = driverTask.Customer_signature;
            driverTaskInDb.Status = driverTask.Status;
            driverTaskInDb.Date_created = driverTask.Date_created;
            driverTaskInDb.Date_modified = driverTask.Date_modified;
            driverTaskInDb.Ip_address = driverTask.Ip_address;
            driverTaskInDb.Auto_assign_type = driverTask.Auto_assign_type;
            driverTaskInDb.Assign_started = driverTask.Assign_started;
            driverTaskInDb.Assignment_status = driverTask.Assignment_status;
            driverTaskInDb.Dropoff_merchant = driverTask.Dropoff_merchant;
            driverTaskInDb.Dropoff_contact_name = driverTask.Dropoff_contact_name;
            driverTaskInDb.Dropoff_contact_number = driverTask.Dropoff_contact_number;
            driverTaskInDb.Drop_address = driverTask.Drop_address;
            driverTaskInDb.Dropoff_lat = driverTask.Dropoff_lat;
            driverTaskInDb.Dropoff_lng = driverTask.Dropoff_lng;
            driverTaskInDb.Recipient_name = driverTask.Recipient_name;
            driverTaskInDb.Critical = driverTask.Critical;

            this.DbContext.Entry(driverTaskInDb).State = System.Data.Entity.EntityState.Modified;
            this.DbContext.SaveChanges();
            return "Hey!! Shady your Driver Task Data Updated Successfully...";
        }
    }
}