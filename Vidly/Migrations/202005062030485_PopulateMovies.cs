namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genres) VALUES (1, 'Hangover', 'Comedy') ");
            Sql("INSERT INTO Movies (Id, Name, Genres) VALUES (2, 'Die Hard', 'Action') ");
            Sql("INSERT INTO Movies (Id, Name, Genres) VALUES (3, 'The Terminator', 'Action') ");
            Sql("INSERT INTO Movies (Id, Name, Genres) VALUES (4, 'Toy Story', 'Family') ");
            Sql("INSERT INTO Movies (Id, Name, Genres) VALUES (5, 'Titanic', 'Romance') ");
        }
        
        public override void Down()
        {
        }
    }
}
