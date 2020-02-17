using DriverApplication.Models;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Repositories
{
    public class DriverAssignmentRepository : RepositoryBase<DriverAssignment>, IDriverAssignmentRepository
    {
        public DriverAssignmentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public string UpdateDriverAssignment(DriverAssignment driverAssignment)
        {
            var driverAssignmentInDb = this.DbContext.mt_driver_assignment.Where(c => c.Assignment_id == driverAssignment.Assignment_id).Single<DriverAssignment>();

            driverAssignmentInDb.Assignment_id = driverAssignment.Assignment_id;
            driverAssignmentInDb.Auto_assign_type = driverAssignment.Auto_assign_type;
            driverAssignmentInDb.Task_id = driverAssignment.Task_id;
            driverAssignmentInDb.Driver_id = driverAssignment.Driver_id;
            driverAssignmentInDb.First_name = driverAssignment.First_name;
            driverAssignmentInDb.Last_name = driverAssignment.Last_name;
            driverAssignmentInDb.Status = driverAssignment.Status;
            driverAssignmentInDb.Task_status = driverAssignment.Task_status;
            driverAssignmentInDb.Date_created = driverAssignment.Date_created;
            driverAssignmentInDb.Date_process = driverAssignment.Date_process;
            driverAssignmentInDb.Ip_address = driverAssignment.Ip_address;

            this.DbContext.Entry(driverAssignmentInDb).State = System.Data.Entity.EntityState.Modified;
            this.DbContext.SaveChanges();
            return "Hey!! Shady your Driver Assignment data Updated Successfully...";
        }
    }
}