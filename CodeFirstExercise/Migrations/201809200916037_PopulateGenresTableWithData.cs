namespace CodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTableWithData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1, 'Action')");
            Sql("INSERT INTO Genres VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres VALUES (4, 'Drama')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Name='Action'");
            Sql("DELETE FROM Genres WHERE Name='Comedy'");
            Sql("DELETE FROM Genres WHERE Name='Horror'");
            Sql("DELETE FROM Genres WHERE Name='Drama'");
        }
    }
}
