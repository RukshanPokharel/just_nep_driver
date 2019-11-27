using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Services
{
    public interface IDriverTeamsService
    {
        IEnumerable<DriverTeam> GetDriverTeams();
        DriverTeam GetDriverTeam(int id);
        void CreateDriverTeam(DriverTeam driverTeam);
        string PutDriverTeam(DriverTeam driverTeam);
        void DeleteDriverTeam(DriverTeam driverTeam);
        void SaveDriverTeam();

    }
}