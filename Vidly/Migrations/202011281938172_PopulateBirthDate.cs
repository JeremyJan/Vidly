namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("update Customers set BirthDate = '1/6/1996' where Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
