namespace HelpingHands.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Donations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Item = c.String(),
                        Quantity = c.String(),
                        DateTime = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adress1 = c.String(),
                        Adress2 = c.String(),
                        Phone = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        Hours = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Locations");
            DropTable("dbo.Donations");
            DropTable("dbo.Categories");
        }
    }
}
