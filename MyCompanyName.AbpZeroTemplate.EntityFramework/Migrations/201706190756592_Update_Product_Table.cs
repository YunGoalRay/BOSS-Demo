namespace MyCompanyName.AbpZeroTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Product_Table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ProductId");
        }
    }
}
