namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Model", c => c.String());
            AddColumn("dbo.Customers", "Lastname", c => c.String());
            AddColumn("dbo.WorkOrders", "DateIn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkOrders", "DateIn");
            DropColumn("dbo.Customers", "Lastname");
            DropColumn("dbo.Cars", "Model");
        }
    }
}
