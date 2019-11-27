using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DriverApplication.Models;
using DriverApplication.Repositories;
using DriverApplication.Utilities;

namespace DriverApplication.Services
{
    public class DriverTasksService : IDriverTasksService
    {
        private readonly IDriverTasksRepository driversTasksRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverTasksService(IDriverTasksRepository driversTasksRepository, IUnitOfWork unitOfWork)
        {
            this.driversTasksRepository = driversTasksRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateDriverTask(DriverTask driverTask)
        {
            driversTasksRepository.Add(driverTask);
        }

        public void DeleteDriverTask(DriverTask driverTask)
        {
            driversTasksRepository.Delete(driverTask);
        }

        public DriverTask GetDriverTask(int id)
        {
            var driverTask = driversTasksRepository.GetById(id);
            return driverTask;
        }

        public IEnumerable<DriverTask> GetDriverTasks()
        {
            var driverTasks = driversTasksRepository.GetAll();
            return driverTasks;
        }

        public string PutDriverTask(DriverTask driverTask)
        {
            string msg = driversTasksRepository.UpdateDriverTask(driverTask);
            return msg;
        }

        public void SaveDriverTask()
        {
            unitOfWork.Commit();
        }
    }
}