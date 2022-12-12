namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(maxLength: 50),
                        TaxAdministration = c.String(maxLength: 150),
                        TaxNumber = c.Int(nullable: false),
                        Address = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.CompanyID);
            
            CreateTable(
                "dbo.Workers",
                c => new
                    {
                        WorkerID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 40),
                        Surname = c.String(maxLength: 40),
                        TC = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID, cascadeDelete: true)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Workers", new[] { "CompanyID" });
            DropTable("dbo.Workers");
            DropTable("dbo.Companies");
        }
    }
}
