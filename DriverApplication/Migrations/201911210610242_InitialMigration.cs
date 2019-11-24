namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerName = c.String(unicode: false),
                        customerContact = c.Int(nullable: false),
                        assignedDriver = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        DriverName = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        DriverContact = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.DriverId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drivers");
            DropTable("dbo.Customers");
        }
    }
}
