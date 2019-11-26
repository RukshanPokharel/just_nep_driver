namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGetterAndSetterInModel : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.mt_driver", new[] { "team_id" });
            AlterColumn("dbo.mt_driver", "User_type", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "On_duty", c => c.Boolean(nullable: false));
            AlterColumn("dbo.mt_driver", "First_name", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Last_name", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Phone", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Username", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Password", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Transport_type_id", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Transport_description", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Licence_plate", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Color", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Status", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Last_login", c => c.DateTime(precision: 0));
            AlterColumn("dbo.mt_driver", "Location_lat", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Location_lng", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Ip_address", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Forgot_pass_code", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Token", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Device_platform", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Enabled_push", c => c.Boolean(nullable: false));
            AlterColumn("dbo.mt_driver", "Profile_photo", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "App_version", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "Last_onduty", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver_team", "User_type", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver_team", "Team_name", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver_team", "Location_accuracy", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver_team", "Status", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver_team", "Ip_address", c => c.String(unicode: false));
           // CreateIndex("dbo.mt_driver", "Team_id");
        }
        
        public override void Down()
        {
            //DropIndex("dbo.mt_driver", new[] { "Team_id" });
            AlterColumn("dbo.mt_driver_team", "Ip_address", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver_team", "Status", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver_team", "Location_accuracy", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver_team", "Team_name", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver_team", "User_type", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Last_onduty", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "App_version", c => c.String(maxLength: 14, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Profile_photo", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Enabled_push", c => c.Int(nullable: false));
            AlterColumn("dbo.mt_driver", "Device_platform", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Token", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Forgot_pass_code", c => c.String(maxLength: 10, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Ip_address", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Location_lng", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Location_lat", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Last_login", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.mt_driver", "Status", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Color", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Licence_plate", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Transport_description", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Transport_type_id", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Password", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Username", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Phone", c => c.String(maxLength: 20, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Email", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "Last_name", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "First_name", c => c.String(nullable: false, maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "On_duty", c => c.Int(nullable: false));
            AlterColumn("dbo.mt_driver", "User_type", c => c.String(maxLength: 50, storeType: "nvarchar"));
            //CreateIndex("dbo.mt_driver", "team_id");
        }
    }
}
