using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DriverApplication.Models;
using DriverApplication.Repositories;
using DriverApplication.Utilities;

namespace DriverApplication.Services
{
    public class DriverAssignmentService : IDriverAssignmentService
    {
        private readonly IDriverAssignmentRepository driverAssignmentRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverAssignmentService(IDriverAssignmentRepository driverAssignmentRepository, IUnitOfWork unitOfWork)
        {
            this.driverAssignmentRepository = driverAssignmentRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateDriverAssignment(DriverAssignment driverAssignment)
        {
            driverAssignmentRepository.Add(driverAssignment);
        }

        public void DeleteDriverAssignment(DriverAssignment driverAssignment)
        {
            driverAssignmentRepository.Delete(driverAssignment);
        }

        public DriverAssignment GetDriverAssignment(int id)
        {
            var driverAssignment = driverAssignmentRepository.GetById(id);
            return driverAssignment;
        }

        public IEnumerable<DriverAssignment> GetDriverAssignments()
        {
            var driverAssignment = driverAssignmentRepository.GetAll();
            return driverAssignment;
        }

        public string PutDriverAssignment(DriverAssignment driverAssignment)
        {
            string msg = driverAssignmentRepository.UpdateDriverAssignment(driverAssignment);
            return msg;
        }

        public void SaveDriverAssignment()
        {
            unitOfWork.Commit();
        }
    }
}