namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Regions", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Cities", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.EventModelEventCities", "EventModel_Id", "dbo.Events");
            DropForeignKey("dbo.EventModelEventCities", "EventCity_Id", "dbo.Cities");
            DropForeignKey("dbo.Events", "EventCustomer_Id", "dbo.Customers");
            DropForeignKey("dbo.Events", "EventCustomer_Id1", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Permissions_Id", "dbo.Permissions");
            DropForeignKey("dbo.Customers", "Rating_Id", "dbo.Ratings");
            DropForeignKey("dbo.Comments", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Comments", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Comments", "Type_Id", "dbo.LikeCommentTypes");
            DropForeignKey("dbo.Likes", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Likes", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Likes", "Type_Id", "dbo.LikeCommentTypes");
            DropForeignKey("dbo.Customers", "EventModel_Id", "dbo.Events");
            DropForeignKey("dbo.Customers", "EventModel_Id1", "dbo.Events");
            DropForeignKey("dbo.Customers", "EventModel_Id2", "dbo.Events");
            DropForeignKey("dbo.Customers", "EventModel_Id3", "dbo.Events");
            DropForeignKey("dbo.EventPersonCategoryEventModels", "EventPersonCategory_Id", "dbo.PersonCategories");
            DropForeignKey("dbo.EventPersonCategoryEventModels", "EventModel_Id", "dbo.Events");
            DropForeignKey("dbo.EventPhotoEventModels", "EventPhoto_Id", "dbo.Photos");
            DropForeignKey("dbo.EventPhotoEventModels", "EventModel_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "Type_Id", "dbo.Types");
            DropIndex("dbo.Cities", new[] { "Region_Id" });
            DropIndex("dbo.Regions", new[] { "Country_Id" });
            DropIndex("dbo.Countries", new[] { "Country" });
            DropIndex("dbo.Events", new[] { "EventCustomer_Id" });
            DropIndex("dbo.Events", new[] { "EventCustomer_Id1" });
            DropIndex("dbo.Events", new[] { "Type_Id" });
            DropIndex("dbo.Comments", new[] { "Customer_Id" });
            DropIndex("dbo.Comments", new[] { "Event_Id" });
            DropIndex("dbo.Comments", new[] { "Type_Id" });
            DropIndex("dbo.Customers", new[] { "Permissions_Id" });
            DropIndex("dbo.Customers", new[] { "Rating_Id" });
            DropIndex("dbo.Customers", new[] { "EventModel_Id" });
            DropIndex("dbo.Customers", new[] { "EventModel_Id1" });
            DropIndex("dbo.Customers", new[] { "EventModel_Id2" });
            DropIndex("dbo.Customers", new[] { "EventModel_Id3" });
            DropIndex("dbo.Permissions", new[] { "Type" });
            DropIndex("dbo.Ratings", new[] { "Name" });
            DropIndex("dbo.Likes", new[] { "Customer_Id" });
            DropIndex("dbo.Likes", new[] { "Event_Id" });
            DropIndex("dbo.Likes", new[] { "Type_Id" });
            DropIndex("dbo.PersonCategories", new[] { "Category" });
            DropIndex("dbo.Types", new[] { "Type" });
            DropIndex("dbo.EventModelEventCities", new[] { "EventModel_Id" });
            DropIndex("dbo.EventModelEventCities", new[] { "EventCity_Id" });
            DropIndex("dbo.EventPersonCategoryEventModels", new[] { "EventPersonCategory_Id" });
            DropIndex("dbo.EventPersonCategoryEventModels", new[] { "EventModel_Id" });
            DropIndex("dbo.EventPhotoEventModels", new[] { "EventPhoto_Id" });
            DropIndex("dbo.EventPhotoEventModels", new[] { "EventModel_Id" });
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
            
            DropTable("dbo.Cities");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Events");
            DropTable("dbo.Comments");
            DropTable("dbo.Customers");
            DropTable("dbo.Permissions");
            DropTable("dbo.Ratings");
            DropTable("dbo.LikeCommentTypes");
            DropTable("dbo.Likes");
            DropTable("dbo.PersonCategories");
            DropTable("dbo.Photos");
            DropTable("dbo.Types");
            DropTable("dbo.EventModelEventCities");
            DropTable("dbo.EventPersonCategoryEventModels");
            DropTable("dbo.EventPhotoEventModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EventPhotoEventModels",
                c => new
                    {
                        EventPhoto_Id = c.Int(nullable: false),
                        EventModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventPhoto_Id, t.EventModel_Id });
            
            CreateTable(
                "dbo.EventPersonCategoryEventModels",
                c => new
                    {
                        EventPersonCategory_Id = c.Int(nullable: false),
                        EventModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventPersonCategory_Id, t.EventModel_Id });
            
            CreateTable(
                "dbo.EventModelEventCities",
                c => new
                    {
                        EventModel_Id = c.Int(nullable: false),
                        EventCity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EventModel_Id, t.EventCity_Id });
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LikeCommentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Salt = c.String(nullable: false, maxLength: 16),
                        Name = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Mobile = c.String(nullable: false, maxLength: 13),
                        Email = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                        Country = c.String(),
                        Address = c.String(),
                        IsBan = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ShowContacts = c.Boolean(nullable: false),
                        Photo = c.String(),
                        Permissions_Id = c.Int(nullable: false),
                        Rating_Id = c.Int(nullable: false),
                        EventModel_Id = c.Int(),
                        EventModel_Id1 = c.Int(),
                        EventModel_Id2 = c.Int(),
                        EventModel_Id3 = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WriteTime = c.DateTime(nullable: false),
                        Text = c.String(nullable: false, maxLength: 256),
                        Customer_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Place = c.String(nullable: false, maxLength: 256),
                        Description = c.String(nullable: false),
                        ShortDescription = c.String(nullable: false, maxLength: 100),
                        IsCharitable = c.Boolean(nullable: false),
                        IsPublished = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Sponsors = c.String(),
                        MainPhoto = c.String(),
                        Cost = c.Double(nullable: false),
                        EventCustomer_Id = c.Int(),
                        EventCustomer_Id1 = c.Int(),
                        Type_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionName = c.String(nullable: false, maxLength: 50),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 50),
                        Region_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.OrderItems", "Pizza_Id", "dbo.Pizzas");
            DropIndex("dbo.OrderItems", new[] { "Pizza_Id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Pizzas");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Customers");
            CreateIndex("dbo.EventPhotoEventModels", "EventModel_Id");
            CreateIndex("dbo.EventPhotoEventModels", "EventPhoto_Id");
            CreateIndex("dbo.EventPersonCategoryEventModels", "EventModel_Id");
            CreateIndex("dbo.EventPersonCategoryEventModels", "EventPersonCategory_Id");
            CreateIndex("dbo.EventModelEventCities", "EventCity_Id");
            CreateIndex("dbo.EventModelEventCities", "EventModel_Id");
            CreateIndex("dbo.Types", "Type", unique: true);
            CreateIndex("dbo.PersonCategories", "Category", unique: true);
            CreateIndex("dbo.Likes", "Type_Id");
            CreateIndex("dbo.Likes", "Event_Id");
            CreateIndex("dbo.Likes", "Customer_Id");
            CreateIndex("dbo.Ratings", "Name", unique: true);
            CreateIndex("dbo.Permissions", "Type", unique: true);
            CreateIndex("dbo.Customers", "EventModel_Id3");
            CreateIndex("dbo.Customers", "EventModel_Id2");
            CreateIndex("dbo.Customers", "EventModel_Id1");
            CreateIndex("dbo.Customers", "EventModel_Id");
            CreateIndex("dbo.Customers", "Rating_Id");
            CreateIndex("dbo.Customers", "Permissions_Id");
            CreateIndex("dbo.Comments", "Type_Id");
            CreateIndex("dbo.Comments", "Event_Id");
            CreateIndex("dbo.Comments", "Customer_Id");
            CreateIndex("dbo.Events", "Type_Id");
            CreateIndex("dbo.Events", "EventCustomer_Id1");
            CreateIndex("dbo.Events", "EventCustomer_Id");
            CreateIndex("dbo.Countries", "Country", unique: true);
            CreateIndex("dbo.Regions", "Country_Id");
            CreateIndex("dbo.Cities", "Region_Id");
            AddForeignKey("dbo.Events", "Type_Id", "dbo.Types", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventPhotoEventModels", "EventModel_Id", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventPhotoEventModels", "EventPhoto_Id", "dbo.Photos", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventPersonCategoryEventModels", "EventModel_Id", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventPersonCategoryEventModels", "EventPersonCategory_Id", "dbo.PersonCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "EventModel_Id3", "dbo.Events", "Id");
            AddForeignKey("dbo.Customers", "EventModel_Id2", "dbo.Events", "Id");
            AddForeignKey("dbo.Customers", "EventModel_Id1", "dbo.Events", "Id");
            AddForeignKey("dbo.Customers", "EventModel_Id", "dbo.Events", "Id");
            AddForeignKey("dbo.Likes", "Type_Id", "dbo.LikeCommentTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Likes", "Event_Id", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Likes", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "Type_Id", "dbo.LikeCommentTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "Event_Id", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "Rating_Id", "dbo.Ratings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "Permissions_Id", "dbo.Permissions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "EventCustomer_Id1", "dbo.Customers", "Id");
            AddForeignKey("dbo.Events", "EventCustomer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.EventModelEventCities", "EventCity_Id", "dbo.Cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EventModelEventCities", "EventModel_Id", "dbo.Events", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cities", "Region_Id", "dbo.Regions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Regions", "Country_Id", "dbo.Countries", "Id", cascadeDelete: true);
        }
    }
}
