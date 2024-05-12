namespace MVCAud3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedClientMovieRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieClients",
                c => new
                    {
                        Movie_ID = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_ID, t.Client_Id })
                .ForeignKey("dbo.Movies", t => t.Movie_ID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Movie_ID)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.MovieClients", "Movie_ID", "dbo.Movies");
            DropIndex("dbo.MovieClients", new[] { "Client_Id" });
            DropIndex("dbo.MovieClients", new[] { "Movie_ID" });
            DropTable("dbo.MovieClients");
        }
    }
}
