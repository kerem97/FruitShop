namespace FruitShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SubTitle = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        Authorization = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mail = c.String(),
                        Number = c.String(),
                        Message = c.String(),
                        Title = c.String(),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Defaults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Description1 = c.String(),
                        Photo1 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Image = c.String(),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Piece = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Name = c.String(),
                        Image = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Fruits");
            DropTable("dbo.Defaults");
            DropTable("dbo.Contacts");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
        }
    }
}
