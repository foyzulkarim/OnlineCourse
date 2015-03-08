namespace SchoolApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            AddColumn("dbo.Students", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "DepartmentId");
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "DepartmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropColumn("dbo.Students", "DepartmentId");
            DropTable("dbo.Departments");
        }
    }
}
