using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DriverApplication.Models;
using DriverApplication.Repositories;
using DriverApplication.Utilities;

namespace DriverApplication.Services
{
    public class DriverServices : IDriverService
    {
        private readonly IDriverRepository driversRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverServices(IDriverRepository driversRepository, IUnitOfWork unitOfWork)
        {
            this.driversRepository = driversRepository;
            this.unitOfWork = unitOfWork;
        }

        // method implementations 
        public void CreateDriver(Driver driver)
        {
            driversRepository.Add(driver);
        }

        public void DeleteDriver(Driver driver)
        {
            driversRepository.Delete(driver);
        }

        public Driver GetDriver(int id)
        {
            var driver = driversRepository.GetById(id);
            return driver;
        }

        public Driver GetDriver(string name)
        {
            var driver = driversRepository.GetDriverByName(name);
            return driver;
        }

        public IEnumerable<Driver> GetDrivers()
        {
            var driver = driversRepository.GetAll();
            return driver;
        }

        public string PutDriver(Driver driver)
        {
            string msg = driversRepository.UpdateDriver(driver);
            return msg;
        }

        public void SaveDriver()
        {
            unitOfWork.Commit();
        }
    }
}