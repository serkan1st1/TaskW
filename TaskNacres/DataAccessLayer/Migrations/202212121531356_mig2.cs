﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workers", "CompanyName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workers", "CompanyName", c => c.Int(nullable: false));
        }
    }
}
