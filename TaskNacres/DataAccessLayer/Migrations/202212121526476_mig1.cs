namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Workers", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Workers", new[] { "CompanyID" });
            RenameColumn(table: "dbo.Workers", name: "CompanyID", newName: "Company_CompanyID");
            AddColumn("dbo.Workers", "CompanyName", c => c.Int(nullable: false));
            AlterColumn("dbo.Workers", "Company_CompanyID", c => c.Int());
            CreateIndex("dbo.Workers", "Company_CompanyID");
            AddForeignKey("dbo.Workers", "Company_CompanyID", "dbo.Companies", "CompanyID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Workers", "Company_CompanyID", "dbo.Companies");
            DropIndex("dbo.Workers", new[] { "Company_CompanyID" });
            AlterColumn("dbo.Workers", "Company_CompanyID", c => c.Int(nullable: false));
            DropColumn("dbo.Workers", "CompanyName");
            RenameColumn(table: "dbo.Workers", name: "Company_CompanyID", newName: "CompanyID");
            CreateIndex("dbo.Workers", "CompanyID");
            AddForeignKey("dbo.Workers", "CompanyID", "dbo.Companies", "CompanyID", cascadeDelete: true);
        }
    }
}
