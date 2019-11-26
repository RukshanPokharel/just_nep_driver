namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriverEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mt_driver",
                c => new
                    {
                        driver_id = c.Int(nullable: false, identity: true),
                        first_name = c.String(nullable: false, maxLength: 255, storeType: "nvarchar"),
                        last_name = c.String(unicode: false),
                        email = c.String(unicode: false),
                        phone = c.String(unicode: false),
                        username = c.String(unicode: false),
                        password = c.String(unicode: false),
                        transport_type_id = c.String(unicode: false),
                        transport_description = c.String(unicode: false),
                        licence_plate = c.String(unicode: false),
                        color = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.driver_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.mt_driver");
        }
    }
}
