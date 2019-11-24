using DriverApplication.Models;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DriverApplication.Utilities

{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DBContext : DbContext
    {
        public DBContext() : base("DBContext") { }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}