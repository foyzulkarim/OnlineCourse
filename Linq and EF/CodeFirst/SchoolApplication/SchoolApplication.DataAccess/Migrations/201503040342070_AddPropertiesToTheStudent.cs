namespace SchoolApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertiesToTheStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "City");
            DropColumn("dbo.Students", "Email");
        }
    }
}
