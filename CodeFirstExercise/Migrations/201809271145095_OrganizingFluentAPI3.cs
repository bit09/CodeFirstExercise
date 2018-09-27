namespace CodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizingFluentAPI3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            AddColumn("dbo.Genres", "VideoID", c => c.Int());
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte());
            CreateIndex("dbo.Genres", "VideoID");
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Genres", "VideoID", "dbo.Videos", "Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Genres", "VideoID", "dbo.Videos");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropIndex("dbo.Genres", new[] { "VideoID" });
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Genres", "VideoID");
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
    }
}
