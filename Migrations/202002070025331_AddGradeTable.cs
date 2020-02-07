namespace FindStructor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGradeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Grades");
        }
    }
}
