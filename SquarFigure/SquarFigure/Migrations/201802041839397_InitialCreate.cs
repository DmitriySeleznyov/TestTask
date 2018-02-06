namespace SquarFigure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Statistics",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        delta = c.Int(nullable: false),
                        x1 = c.Int(nullable: false),
                        x2 = c.Int(nullable: false),
                        func = c.String(),
                        result = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Statistics");
        }
    }
}
