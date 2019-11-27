namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DriverTaskTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mt_driver_task",
                c => new
                    {
                        Task_id = c.Int(nullable: false, identity: true),
                        Order_id = c.Int(nullable: false),
                        User_type = c.String(maxLength: 100, storeType: "nvarchar"),
                        User_id = c.Int(nullable: false),
                        Task_description = c.String(maxLength: 255, storeType: "nvarchar"),
                        Trans_type = c.String(maxLength: 255, storeType: "nvarchar"),
                        Contact_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        Email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        Customer_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        Delivery_date = c.DateTime(precision: 0),
                        Delivery_address = c.String(maxLength: 255, storeType: "nvarchar"),
                        Team_id = c.Int(nullable: false),
                        Driver_id = c.Int(nullable: false),
                        Task_lat = c.String(maxLength: 50, storeType: "nvarchar"),
                        Task_lng = c.String(maxLength: 50, storeType: "nvarchar"),
                        Customer_signature = c.String(maxLength: 255, storeType: "nvarchar"),
                        Status = c.String(maxLength: 255, storeType: "nvarchar"),
                        Date_created = c.DateTime(precision: 0),
                        Date_modified = c.DateTime(precision: 0),
                        Ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                        Auto_assign_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        Assign_started = c.DateTime(precision: 0),
                        Assignment_status = c.String(maxLength: 255, storeType: "nvarchar"),
                        Dropoff_merchant = c.Int(nullable: false),
                        Dropoff_contact_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        Dropoff_contact_number = c.String(maxLength: 20, storeType: "nvarchar"),
                        Drop_address = c.String(maxLength: 255, storeType: "nvarchar"),
                        Dropoff_lat = c.String(maxLength: 30, storeType: "nvarchar"),
                        Dropoff_lng = c.String(maxLength: 30, storeType: "nvarchar"),
                        Recipient_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        Critical = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Task_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.mt_driver_task");
        }
    }
}
