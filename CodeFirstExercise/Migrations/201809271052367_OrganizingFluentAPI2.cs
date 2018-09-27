namespace CodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrganizingFluentAPI2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            AlterColumn("dbo.Videos", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Videos", "Genre_Id");
            AddForeignKey("dbo.Videos", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
