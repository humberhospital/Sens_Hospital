namespace Sens_Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idenModelsVolunteer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CurrentVolunteerPositions",
                c => new
                    {
                        CvpID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CvpID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        VolunteerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VolunteerID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Volunteers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.CurrentVolunteerPositions", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Volunteers", new[] { "DepartmentID" });
            DropIndex("dbo.CurrentVolunteerPositions", new[] { "DepartmentID" });
            DropTable("dbo.Volunteers");
            DropTable("dbo.CurrentVolunteerPositions");
        }
    }
}
