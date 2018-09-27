namespace CodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizingFluentAPI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "GenreId");
        }
    }
}
