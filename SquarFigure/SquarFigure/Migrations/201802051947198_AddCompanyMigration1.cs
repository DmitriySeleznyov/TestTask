namespace SquarFigure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Statistics", "delta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Statistics", "x1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Statistics", "x2", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Statistics", "result", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Statistics", "result", c => c.Double(nullable: false));
            AlterColumn("dbo.Statistics", "x2", c => c.Int(nullable: false));
            AlterColumn("dbo.Statistics", "x1", c => c.Int(nullable: false));
            AlterColumn("dbo.Statistics", "delta", c => c.Double(nullable: false));
        }
    }
}
