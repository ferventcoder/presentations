namespace DropkicKExample.migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialStructure : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dk.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dk.Parents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dk.Children",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ParentObjectId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dk.Parents", t => t.ParentObjectId, cascadeDelete: true)
                .Index(t => t.ParentObjectId);
            
        }
        
        public override void Down()
        {
            DropIndex("dk.Children", new[] { "ParentObjectId" });
            DropForeignKey("dk.Children", "ParentObjectId", "dk.Parents");
            DropTable("dk.Children");
            DropTable("dk.Parents");
            DropTable("dk.Users");
        }
    }
}
