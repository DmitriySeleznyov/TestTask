namespace SquarFigure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Statistics", "delta", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Statistics", "delta", c => c.Int(nullable: false));
        }
    }
}
