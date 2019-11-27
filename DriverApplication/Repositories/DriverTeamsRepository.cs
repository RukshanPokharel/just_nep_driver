using DriverApplication.Models;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Repositories
{
    public class DriverTeamsRepository: RepositoryBase<DriverTeam>, IDriverTeamsRepository
    {
        public DriverTeamsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public string UpdateDriverTeam(DriverTeam driverTeam)
        {
            var driverTeamInDb = this.DbContext.mt_driver_team.Where(c => c.Team_id == driverTeam.Team_id).Single<DriverTeam>();

            driverTeamInDb.Team_id = driverTeam.Team_id;
            driverTeamInDb.User_type = driverTeam.User_type;
            driverTeamInDb.User_id = driverTeam.User_id;
            driverTeamInDb.Team_name = driverTeam.Team_name;
            driverTeamInDb.Location_accuracy = driverTeam.Location_accuracy;
            driverTeamInDb.Status = driverTeam.Status;
            driverTeamInDb.Date_created = driverTeam.Date_created;
            driverTeamInDb.Date_modified = driverTeam.Date_modified;
            driverTeamInDb.Ip_address = driverTeam.Ip_address;

            this.DbContext.Entry(driverTeamInDb).State = System.Data.Entity.EntityState.Modified;
            this.DbContext.SaveChanges();
            return "Hey!! Shady your Driver Team Data Updated Successfully...";
        }
    }
}