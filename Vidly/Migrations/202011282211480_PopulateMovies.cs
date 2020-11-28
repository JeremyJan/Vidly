namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) values ('Hangover', 1, '11/6/2009', '5/4/2016', 5)");
            Sql("Insert Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) values ('Die Hard', 2, '7/15/1988', '1/4/2016', 2)");
            Sql("Insert Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) values ('The Terminator', 2, '10/26/1984', '3/12/2017', 3)");
            Sql("Insert Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) values ('Toy Story', 3, '11/19/1995', '6/4/2017', 7)");
            Sql("Insert Movies (Name, GenreId, ReleaseDate, AddedDate, NumberInStock) values ('Titanic', 4, '12/19/1997', '7/4/2016', 8)");
        }

        
        public override void Down()
        {
        }
    }
}
