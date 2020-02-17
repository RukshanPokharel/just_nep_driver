using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Services
{
    public interface IDriverTasksService
    {
        IEnumerable<DriverTask> GetDriverTasks();
        DriverTask GetDriverTask(int id);
        void CreateDriverTask(DriverTask driverTask);
        string PutDriverTask(DriverTask driverTask);
        void DeleteDriverTask(DriverTask driverTask);
        void SaveDriverTask();
    }
}