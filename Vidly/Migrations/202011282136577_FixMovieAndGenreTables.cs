namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieAndGenreTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Genres", "ReleaseDate");
            DropColumn("dbo.Genres", "AddedDate");
            DropColumn("dbo.Genres", "NumberInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Genres", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "AddedDate");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
