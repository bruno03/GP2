namespace GP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFinalPriceWI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkItems", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.WorkItems", "FinalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WorkItems", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.WorkItems", "FinalPrice");
            DropColumn("dbo.WorkItems", "UnitPrice");
        }
    }
}
