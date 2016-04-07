namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addWorkItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkItems",
                c => new
                    {
                        WorkItemID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Quantity = c.Single(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkOrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkItemID)
                .ForeignKey("dbo.WorkOrders", t => t.WorkOrderID, cascadeDelete: true)
                .Index(t => t.WorkOrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkItems", "WorkOrderID", "dbo.WorkOrders");
            DropIndex("dbo.WorkItems", new[] { "WorkOrderID" });
            DropTable("dbo.WorkItems");
        }
    }
}
