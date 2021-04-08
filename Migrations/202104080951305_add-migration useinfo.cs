namespace Sens_Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationuseinfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Donations", "DonorID", "dbo.DonorInfoes");
            DropIndex("dbo.Donations", new[] { "DonorID" });
            AddColumn("dbo.Donations", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Donations", "UserID");
            AddForeignKey("dbo.Donations", "UserID", "dbo.UserInfoes", "UserID", cascadeDelete: true);
            DropColumn("dbo.Donations", "DonorID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Donations", "DonorID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Donations", "UserID", "dbo.UserInfoes");
            DropIndex("dbo.Donations", new[] { "UserID" });
            DropColumn("dbo.Donations", "UserID");
            CreateIndex("dbo.Donations", "DonorID");
            AddForeignKey("dbo.Donations", "DonorID", "dbo.DonorInfoes", "DonorID", cascadeDelete: true);
        }
    }
}
