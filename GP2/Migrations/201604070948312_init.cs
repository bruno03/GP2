namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Customer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.WorkOrders", "CarID", "dbo.Cars");
            DropIndex("dbo.Cars", new[] { "Customer_CustomerID" });
            DropIndex("dbo.WorkOrders", new[] { "CarID" });
            AddColumn("dbo.Cars", "CustomerID", c => c.Int(nullable: false));
            DropColumn("dbo.Cars", "Model");
            DropColumn("dbo.Cars", "CustID");
            DropColumn("dbo.Cars", "Customer_CustomerID");
            DropColumn("dbo.Customers", "Lastname");
            DropTable("dbo.WorkOrders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WorkOrders",
                c => new
                    {
                        WorkOrderID = c.Int(nullable: false, identity: true),
                        CarID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WorkOrderID);
            
            AddColumn("dbo.Customers", "Lastname", c => c.String());
            AddColumn("dbo.Cars", "Customer_CustomerID", c => c.Int());
            AddColumn("dbo.Cars", "CustID", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Model", c => c.String());
            DropColumn("dbo.Cars", "CustomerID");
            CreateIndex("dbo.WorkOrders", "CarID");
            CreateIndex("dbo.Cars", "Customer_CustomerID");
            AddForeignKey("dbo.WorkOrders", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "Customer_CustomerID", "dbo.Customers", "CustomerID");
        }
    }
}
