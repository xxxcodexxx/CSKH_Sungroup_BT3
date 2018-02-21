namespace CSKH_Sungroup_BT3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Donnt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Passport", c => c.String(maxLength: 30));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "Passport", c => c.Int(nullable: false));
        }
    }
}
