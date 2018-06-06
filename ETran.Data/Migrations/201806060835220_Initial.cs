namespace ETran.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attachments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ReportId = c.Int(),
                        AttachmentFile = c.Binary(),
                        AttachmentName = c.String(),
                        AttachmentType = c.String(),
                        AttachmentLength = c.Int(nullable: false),
                        Remark = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CountryName = c.String(maxLength: 150),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoverImages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FileName = c.String(maxLength: 100),
                        Extension = c.String(maxLength: 50),
                        Mime = c.String(maxLength: 50),
                        Attachment = c.Binary(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        ImageId = c.Int(nullable: false),
                        PostedDate = c.DateTime(nullable: false),
                        PublicDate = c.DateTime(),
                        Available = c.Boolean(nullable: false),
                        Description = c.String(),
                        CategoryId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        Content = c.String(),
                        PostedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        Category_Id = c.Guid(),
                        Image_Id = c.Guid(),
                        Status_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.CoverImages", t => t.Image_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Image_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.NewsComments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NewsId = c.Int(nullable: false),
                        ParentCommentId = c.Int(),
                        Comment = c.String(),
                        UserProfileId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        NewsComment_Id = c.Guid(),
                        News_Id = c.Guid(),
                        ParentComment_Id = c.Guid(),
                        UserProfile_Id = c.Guid(),
                        News_Id1 = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewsComments", t => t.NewsComment_Id)
                .ForeignKey("dbo.News", t => t.News_Id)
                .ForeignKey("dbo.News", t => t.ParentComment_Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .ForeignKey("dbo.News", t => t.News_Id1)
                .Index(t => t.NewsComment_Id)
                .Index(t => t.News_Id)
                .Index(t => t.ParentComment_Id)
                .Index(t => t.UserProfile_Id)
                .Index(t => t.News_Id1);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        NewsId = c.Int(nullable: false),
                        CommentId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        DocumentComment_Id = c.Guid(),
                        DocumentNews_Id = c.Guid(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewsComments", t => t.DocumentComment_Id)
                .ForeignKey("dbo.News", t => t.DocumentNews_Id)
                .ForeignKey("dbo.UserProfiles", t => t.User_Id)
                .Index(t => t.DocumentComment_Id)
                .Index(t => t.DocumentNews_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        ConfirmPassword = c.String(maxLength: 50),
                        DisplayName = c.String(maxLength: 255),
                        Email = c.String(maxLength: 100),
                        NickName = c.String(maxLength: 50),
                        ThumbnailPhoto = c.Binary(),
                        Domain = c.String(),
                        ReceiveEmail = c.Boolean(),
                        Active = c.Boolean(),
                        CountryId = c.Int(),
                        TelephoneNumber = c.String(maxLength: 30),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        Country_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserProfileId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        Role_Id = c.Guid(),
                        UserProfile_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .ForeignKey("dbo.UserProfiles", t => t.UserProfile_Id)
                .Index(t => t.Role_Id)
                .Index(t => t.UserProfile_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 256),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShareNews",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NewsId = c.Int(nullable: false),
                        Users = c.String(),
                        IsMailSent = c.Boolean(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        News_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.News", t => t.News_Id)
                .Index(t => t.News_Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserLoginHistories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Int(nullable: false),
                        AccessToken = c.Guid(nullable: false),
                        IsLoggedOut = c.Boolean(nullable: false),
                        IsAppToken = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        DeletedDate = c.DateTime(),
                        DeletedBy = c.Int(),
                        User_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserProfiles", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserLoginHistories", "User_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.News", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.ShareNews", "News_Id", "dbo.News");
            DropForeignKey("dbo.NewsComments", "News_Id1", "dbo.News");
            DropForeignKey("dbo.NewsComments", "UserProfile_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.NewsComments", "ParentComment_Id", "dbo.News");
            DropForeignKey("dbo.Likes", "User_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.UserRoles", "UserProfile_Id", "dbo.UserProfiles");
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserProfiles", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Likes", "DocumentNews_Id", "dbo.News");
            DropForeignKey("dbo.Likes", "DocumentComment_Id", "dbo.NewsComments");
            DropForeignKey("dbo.NewsComments", "News_Id", "dbo.News");
            DropForeignKey("dbo.NewsComments", "NewsComment_Id", "dbo.NewsComments");
            DropForeignKey("dbo.News", "Image_Id", "dbo.CoverImages");
            DropForeignKey("dbo.News", "Category_Id", "dbo.Categories");
            DropIndex("dbo.UserLoginHistories", new[] { "User_Id" });
            DropIndex("dbo.ShareNews", new[] { "News_Id" });
            DropIndex("dbo.UserRoles", new[] { "UserProfile_Id" });
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserProfiles", new[] { "Country_Id" });
            DropIndex("dbo.Likes", new[] { "User_Id" });
            DropIndex("dbo.Likes", new[] { "DocumentNews_Id" });
            DropIndex("dbo.Likes", new[] { "DocumentComment_Id" });
            DropIndex("dbo.NewsComments", new[] { "News_Id1" });
            DropIndex("dbo.NewsComments", new[] { "UserProfile_Id" });
            DropIndex("dbo.NewsComments", new[] { "ParentComment_Id" });
            DropIndex("dbo.NewsComments", new[] { "News_Id" });
            DropIndex("dbo.NewsComments", new[] { "NewsComment_Id" });
            DropIndex("dbo.News", new[] { "Status_Id" });
            DropIndex("dbo.News", new[] { "Image_Id" });
            DropIndex("dbo.News", new[] { "Category_Id" });
            DropTable("dbo.UserLoginHistories");
            DropTable("dbo.Status");
            DropTable("dbo.ShareNews");
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Likes");
            DropTable("dbo.NewsComments");
            DropTable("dbo.News");
            DropTable("dbo.CoverImages");
            DropTable("dbo.Countries");
            DropTable("dbo.Categories");
            DropTable("dbo.Attachments");
        }
    }
}
