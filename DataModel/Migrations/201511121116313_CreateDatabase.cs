namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.String(nullable: false, maxLength: 13),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Pizza_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pizzas", t => t.Pizza_Id)
                .Index(t => t.Pizza_Id);
            
            CreateTable(
                "dbo.Pizzas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Photo = c.String(),
                        Description = c.String(),
                        Weight = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        IsStandart = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 255),
                        CustomerPhone = c.String(nullable: false, maxLength: 13),
                        CustomerAddress = c.String(nullable: false, maxLength: 255),
                        TotalSum = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Pizza_Id", "dbo.Pizzas");
            DropIndex("dbo.OrderItems", new[] { "Pizza_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Pizzas");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Customers");
        }
    }
}
