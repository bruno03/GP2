namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelation2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        WorkOrderID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkOrderID)
                .ForeignKey("dbo.Cars", t => t.CarID, cascadeDelete: true)
                .Index(t => t.CarID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkOrders", "CarID", "dbo.Cars");
            DropIndex("dbo.WorkOrders", new[] { "CarID" });
            DropTable("dbo.WorkOrders");
        }
    }
}
