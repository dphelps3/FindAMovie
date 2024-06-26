﻿namespace FindAMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeMoreMoviePropertiesNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
        }
    }
}
