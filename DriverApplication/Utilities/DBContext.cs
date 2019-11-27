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

        public DbSet<Driver> mt_driver { get; set; }
        public DbSet<DriverTeam> mt_driver_team { get; set; }
        public DbSet<DriverTask> mt_driver_task { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().ToTable("mt_driver");         //changing table name in database using fluentAPI
            modelBuilder.Entity<DriverTeam>().ToTable("mt_driver_team");
            modelBuilder.Entity<DriverTask>().ToTable("mt_driver_task");

            //base.OnModelCreating(modelBuilder);
        }
    }
}