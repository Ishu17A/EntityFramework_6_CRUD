namespace EF_Assignmnent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class isaaan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Salary", c => c.String());
        }
    }
}
