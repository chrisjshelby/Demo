namespace Demo.WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactPhones",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        PhoneType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contacts", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactPhones", "ContactID", "dbo.Contacts");
            DropIndex("dbo.ContactPhones", new[] { "ContactID" });
            DropTable("dbo.Contacts");
            DropTable("dbo.ContactPhones");
        }
    }
}
