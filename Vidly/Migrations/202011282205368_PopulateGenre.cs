namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres (GenreName) values ('Comedy')");
            Sql("insert into Genres (GenreName) values ('Action')");
            Sql("insert into Genres (GenreName) values ('Family')");
            Sql("insert into Genres (GenreName) values ('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
