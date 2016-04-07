namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelation : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cars", "CustomerID");
            AddForeignKey("dbo.Cars", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Cars", new[] { "CustomerID" });
        }
    }
}
