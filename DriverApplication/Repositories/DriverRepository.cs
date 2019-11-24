using DriverApplication.Models;
using DriverApplication.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DriverApplication.Repositories
{
    public class DriverRepository : RepositoryBase<Driver>, IDriverRepository
    {
        public DriverRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public Driver GetDriverByName(string driverName)
        {
            var driver = this.DbContext.Drivers.Where(c => c.DriverName == driverName).FirstOrDefault();

            return driver;

        }


    }
}