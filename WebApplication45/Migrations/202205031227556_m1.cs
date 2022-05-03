namespace WebApplication45.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.employees");
        }
    }
}
