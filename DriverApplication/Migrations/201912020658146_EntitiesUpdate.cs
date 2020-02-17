namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntitiesUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mt_driver",
                c => new
                    {
                        driver_id = c.Int(nullable: false, identity: true),
                        user_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        user_id = c.Int(nullable: false),
                        on_duty = c.Boolean(nullable: false),
                        first_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        last_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        email = c.String(maxLength: 100, storeType: "nvarchar"),
                        phone = c.String(maxLength: 20, storeType: "nvarchar"),
                        username = c.String(maxLength: 100, storeType: "nvarchar"),
                        password = c.String(maxLength: 100, storeType: "nvarchar"),
                        team_id = c.Int(nullable: false),
                        transport_type_id = c.String(maxLength: 50, storeType: "nvarchar"),
                        transport_description = c.String(maxLength: 255, storeType: "nvarchar"),
                        licence_plate = c.String(maxLength: 255, storeType: "nvarchar"),
                        color = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        date_created = c.DateTime(precision: 0),
                        date_modified = c.DateTime(precision: 0),
                        last_login = c.DateTime(precision: 0),
                        last_online = c.Int(nullable: false),
                        location_address = c.String(unicode: false),
                        location_lat = c.String(maxLength: 50, storeType: "nvarchar"),
                        location_lng = c.String(maxLength: 50, storeType: "nvarchar"),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                        forgot_pass_code = c.String(maxLength: 10, storeType: "nvarchar"),
                        token = c.String(maxLength: 255, storeType: "nvarchar"),
                        device_id = c.String(unicode: false),
                        device_platform = c.String(maxLength: 50, storeType: "nvarchar"),
                        enabled_push = c.Boolean(nullable: false),
                        profile_photo = c.String(maxLength: 255, storeType: "nvarchar"),
                        is_signup = c.Int(nullable: false),
                        app_version = c.String(maxLength: 14, storeType: "nvarchar"),
                        last_onduty = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.driver_id)
                .ForeignKey("dbo.mt_driver_team", t => t.team_id)
                .Index(t => t.team_id);
            
            CreateTable(
                "dbo.mt_driver_team",
                c => new
                    {
                        team_id = c.Int(nullable: false, identity: true),
                        user_type = c.String(maxLength: 100, storeType: "nvarchar"),
                        user_id = c.Int(nullable: false),
                        team_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        location_accuracy = c.String(maxLength: 50, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        date_created = c.DateTime(precision: 0),
                        date_modified = c.DateTime(precision: 0),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.team_id);
            
            CreateTable(
                "dbo.mt_driver_assignment",
                c => new
                    {
                        assignment_id = c.Int(nullable: false, identity: true),
                        auto_assign_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        task_id = c.Int(nullable: false),
                        driver_id = c.Int(nullable: false),
                        first_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        last_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 100, storeType: "nvarchar"),
                        task_status = c.String(maxLength: 255, storeType: "nvarchar"),
                        date_created = c.DateTime(precision: 0),
                        date_process = c.DateTime(precision: 0),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.assignment_id);
            
            CreateTable(
                "dbo.mt_driver_bulk_push",
                c => new
                    {
                        bulk_id = c.Int(nullable: false, identity: true),
                        push_title = c.String(maxLength: 255, storeType: "nvarchar"),
                        push_message = c.String(unicode: false),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        date_created = c.DateTime(precision: 0),
                        date_process = c.DateTime(precision: 0),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                        team_id = c.Int(nullable: false),
                        user_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.bulk_id);
            
            CreateTable(
                "dbo.mt_driver_pushlog",
                c => new
                    {
                        push_id = c.Int(nullable: false, identity: true),
                        device_platform = c.String(maxLength: 50, storeType: "nvarchar"),
                        device_id = c.String(maxLength: 255, storeType: "nvarchar"),
                        push_title = c.String(maxLength: 255, storeType: "nvarchar"),
                        push_message = c.String(maxLength: 255, storeType: "nvarchar"),
                        push_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        actions = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        json_response = c.String(maxLength: 255, storeType: "nvarchar"),
                        order_id = c.Int(nullable: false),
                        driver_id = c.Int(nullable: false),
                        task_id = c.Int(nullable: false),
                        date_created = c.DateTime(precision: 0),
                        date_process = c.DateTime(precision: 0),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                        is_read = c.Int(nullable: false),
                        bulk_id = c.Int(nullable: false),
                        user_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.push_id);
            
            CreateTable(
                "dbo.mt_driver_task",
                c => new
                    {
                        task_id = c.Int(nullable: false, identity: true),
                        order_id = c.Int(nullable: false),
                        user_type = c.String(maxLength: 100, storeType: "nvarchar"),
                        user_id = c.Int(nullable: false),
                        task_description = c.String(maxLength: 255, storeType: "nvarchar"),
                        trans_type = c.String(maxLength: 255, storeType: "nvarchar"),
                        contact_number = c.String(maxLength: 50, storeType: "nvarchar"),
                        email_address = c.String(maxLength: 200, storeType: "nvarchar"),
                        customer_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        delivery_date = c.DateTime(precision: 0),
                        delivery_address = c.String(maxLength: 255, storeType: "nvarchar"),
                        team_id = c.Int(nullable: false),
                        driver_id = c.Int(nullable: false),
                        task_lat = c.String(maxLength: 50, storeType: "nvarchar"),
                        task_lng = c.String(maxLength: 50, storeType: "nvarchar"),
                        customer_signature = c.String(maxLength: 255, storeType: "nvarchar"),
                        status = c.String(maxLength: 255, storeType: "nvarchar"),
                        date_created = c.DateTime(precision: 0),
                        date_modified = c.DateTime(precision: 0),
                        ip_address = c.String(maxLength: 50, storeType: "nvarchar"),
                        auto_assign_type = c.String(maxLength: 50, storeType: "nvarchar"),
                        assign_started = c.DateTime(precision: 0),
                        assignment_status = c.String(maxLength: 255, storeType: "nvarchar"),
                        dropoff_merchant = c.Int(nullable: false),
                        dropoff_contact_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        dropoff_contact_number = c.String(maxLength: 20, storeType: "nvarchar"),
                        drop_address = c.String(maxLength: 255, storeType: "nvarchar"),
                        dropoff_lat = c.String(maxLength: 30, storeType: "nvarchar"),
                        dropoff_lng = c.String(maxLength: 30, storeType: "nvarchar"),
                        recipient_name = c.String(maxLength: 255, storeType: "nvarchar"),
                        critical = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.task_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mt_driver", "team_id", "dbo.mt_driver_team");
            DropIndex("dbo.mt_driver", new[] { "team_id" });
            DropTable("dbo.mt_driver_task");
            DropTable("dbo.mt_driver_pushlog");
            DropTable("dbo.mt_driver_bulk_push");
            DropTable("dbo.mt_driver_assignment");
            DropTable("dbo.mt_driver_team");
            DropTable("dbo.mt_driver");
        }
    }
}
