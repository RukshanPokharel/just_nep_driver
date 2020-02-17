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
        public DbSet<DriverAssignment> mt_driver_assignment { get; set; }
        public DbSet<PushLog> mt_driver_pushlog { get; set; }
        public DbSet<BulkPush> mt_driver_bulk_push { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Driver>().ToTable("mt_driver");         //changing table name in database using fluentAPI
            modelBuilder.Entity<DriverTeam>().ToTable("mt_driver_team");
            modelBuilder.Entity<DriverTask>().ToTable("mt_driver_task");
            modelBuilder.Entity<DriverAssignment>().ToTable("mt_driver_assignment");
            modelBuilder.Entity<PushLog>().ToTable("mt_driver_pushlog");
            modelBuilder.Entity<BulkPush>().ToTable("mt_driver_bulk_push");

            //-------//
            //adding foreign key through fluentAPI
            modelBuilder.Entity<Driver>()
                .HasRequired<DriverTeam>(d => d.DriverTeam1)
                .WithMany(dt => dt.Drivers)
                .HasForeignKey(conf => conf.Team_id)
                .WillCascadeOnDelete(false);    // specifiing cascade to false for this foreign key...

            //--------//

            // By default entity framework sets the action for foreign key relationships to cascade
            // to set the cascading referential integrity constraint to No action while deleting do the following..

            //foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
            //                                             .SelectMany(e => e.GetForeignKeys()))
            //{
            //    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            //}

            // --------// 


        }
    }
}