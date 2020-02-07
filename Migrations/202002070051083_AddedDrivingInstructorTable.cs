namespace FindStructor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDrivingInstructorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DrivingInstructors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentityId = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        RegistrationDate = c.DateTime(nullable: false),
                        PricePerLesson = c.Single(nullable: false),
                        GradeId = c.Byte(nullable: false),
                        RatingAvarage = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DrivingInstructors", "GradeId", "dbo.Grades");
            DropIndex("dbo.DrivingInstructors", new[] { "GradeId" });
            DropTable("dbo.DrivingInstructors");
        }
    }
}
