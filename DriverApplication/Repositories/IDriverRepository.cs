using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Repositories
{
    public interface IDriverRepository : IRepository<Driver>
    {
        Driver GetDriverByName(string driverName);
    }
}