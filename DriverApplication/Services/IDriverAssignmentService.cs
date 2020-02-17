using DriverApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriverApplication.Services
{
    public interface IDriverAssignmentService
    {
        IEnumerable<DriverAssignment> GetDriverAssignments();
        DriverAssignment GetDriverAssignment(int id);
        void CreateDriverAssignment(DriverAssignment driverAssignment);
        string PutDriverAssignment(DriverAssignment driverAssignment);
        void DeleteDriverAssignment(DriverAssignment driverAssignment);
        void SaveDriverAssignment();
    }
}