namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('Hangover', 'Comedy', '1/1/2011', '1/2/2015', 4)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('Superbad', 'Comedy', '1/1/2012', '1/2/2012', 5)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('The Ring', 'Horror', '1/1/2006', '1/2/2016', 1)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('Grease',   'Comedy', '1/1/1982', '1/2/2017', 2)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('The Exorcist', 'Horror', '1/1/2008', '1/2/2018', 2)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('Die Hard', 'Action', '1/1/2000', '1/2/2014', 1)");
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, DateAdded, NumberInStock) " +
                           "VALUES ('Titanic', 'Romance', '1/1/2000', '1/2/2010', 0)");
        }
        
        public override void Down()
        {
        }
    }
}
