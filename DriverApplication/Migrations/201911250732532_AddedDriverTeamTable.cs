namespace DriverApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDriverTeamTable : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("dbo.mt_driver", "user_type", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "user_id", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "on_duty", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "team_id", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "status", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "date_created", c => c.DateTime(precision: 0));
            AddColumn("dbo.mt_driver", "date_modified", c => c.DateTime(precision: 0));
            AddColumn("dbo.mt_driver", "last_login", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.mt_driver", "last_online", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "location_address", c => c.String(unicode: false));
            AddColumn("dbo.mt_driver", "location_lat", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "location_lng", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "ip_address", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "forgot_pass_code", c => c.String(maxLength: 10, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "token", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "device_id", c => c.String(unicode: false));
            AddColumn("dbo.mt_driver", "device_platform", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "enabled_push", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "profile_photo", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "is_signup", c => c.Int(nullable: false));
            AddColumn("dbo.mt_driver", "app_version", c => c.String(maxLength: 14, storeType: "nvarchar"));
            AddColumn("dbo.mt_driver", "last_onduty", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "last_name", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "email", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "phone", c => c.String(maxLength: 20, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "username", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "password", c => c.String(maxLength: 100, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "transport_type_id", c => c.String(maxLength: 50, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "transport_description", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "licence_plate", c => c.String(maxLength: 255, storeType: "nvarchar"));
            AlterColumn("dbo.mt_driver", "color", c => c.String(maxLength: 255, storeType: "nvarchar"));
            CreateIndex("dbo.mt_driver", "team_id");
            AddForeignKey("dbo.mt_driver", "team_id", "dbo.mt_driver_team", "team_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mt_driver", "team_id", "dbo.mt_driver_team");
            DropIndex("dbo.mt_driver", new[] { "team_id" });
            AlterColumn("dbo.mt_driver", "color", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "licence_plate", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "transport_description", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "transport_type_id", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "password", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "username", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "phone", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "email", c => c.String(unicode: false));
            AlterColumn("dbo.mt_driver", "last_name", c => c.String(unicode: false));
            DropColumn("dbo.mt_driver", "last_onduty");
            DropColumn("dbo.mt_driver", "app_version");
            DropColumn("dbo.mt_driver", "is_signup");
            DropColumn("dbo.mt_driver", "profile_photo");
            DropColumn("dbo.mt_driver", "enabled_push");
            DropColumn("dbo.mt_driver", "device_platform");
            DropColumn("dbo.mt_driver", "device_id");
            DropColumn("dbo.mt_driver", "token");
            DropColumn("dbo.mt_driver", "forgot_pass_code");
            DropColumn("dbo.mt_driver", "ip_address");
            DropColumn("dbo.mt_driver", "location_lng");
            DropColumn("dbo.mt_driver", "location_lat");
            DropColumn("dbo.mt_driver", "location_address");
            DropColumn("dbo.mt_driver", "last_online");
            DropColumn("dbo.mt_driver", "last_login");
            DropColumn("dbo.mt_driver", "date_modified");
            DropColumn("dbo.mt_driver", "date_created");
            DropColumn("dbo.mt_driver", "status");
            DropColumn("dbo.mt_driver", "team_id");
            DropColumn("dbo.mt_driver", "on_duty");
            DropColumn("dbo.mt_driver", "user_id");
            DropColumn("dbo.mt_driver", "user_type");
            DropTable("dbo.mt_driver_team");
        }
    }
}
