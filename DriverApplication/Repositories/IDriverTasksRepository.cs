using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Repositories
{
    public interface IDriverTasksRepository : IRepository<DriverTask>
    {
        string UpdateDriver(DriverTask driverTask);
    }
}