namespace FindAMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Genre", c => c.String());
            AddColumn("dbo.Movies", "DateReleased", c => c.DateTime());
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Movies", "InStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "InStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "DateReleased");
            DropColumn("dbo.Movies", "Genre");
        }
    }
}
