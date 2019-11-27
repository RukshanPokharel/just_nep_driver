using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DriverApplication.Models;
using DriverApplication.Repositories;
using DriverApplication.Utilities;

namespace DriverApplication.Services
{
    public class DriverTeamsService : IDriverTeamsService
    {
        private readonly IDriverTeamsRepository driversTeamsRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverTeamsService(IDriverTeamsRepository driversTeamsRepository, IUnitOfWork unitOfWork)
        {
            this.driversTeamsRepository = driversTeamsRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateDriverTeam(DriverTeam driverTeam)
        {
            driversTeamsRepository.Add(driverTeam);
        }

        public void DeleteDriverTeam(DriverTeam driverTeam)
        {
            driversTeamsRepository.Delete(driverTeam);
        }

        public DriverTeam GetDriverTeam(int id)
        {
            var driverTeam = driversTeamsRepository.GetById(id);
            return driverTeam;
        }

        public IEnumerable<DriverTeam> GetDriverTeams()
        {
            var driverTeams = driversTeamsRepository.GetAll();
            return driverTeams;
        }

        public string PutDriverTeam(DriverTeam driverTeam)
        {
            string msg = driversTeamsRepository.UpdateDriverTeam(driverTeam);
            return msg;
        }

        public void SaveDriverTeam()
        {
            unitOfWork.Commit();
        }
    }
}