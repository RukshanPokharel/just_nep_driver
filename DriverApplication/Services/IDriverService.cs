using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Services
{
    public interface IDriverService
    {
        IEnumerable<Driver> GetDrivers();
        Driver GetDriver(int id);
        Driver GetDriver(string name);
        void CreateDriver(Driver driver);
        void  PutDriver(Driver driver);
        void  DeleteDriver(Driver driver);
        void SaveDriver();

    }

}