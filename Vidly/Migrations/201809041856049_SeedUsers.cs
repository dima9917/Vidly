namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'307c993b-8952-4f46-97db-58a4ae226814', N'admin@vidly.com', 0, N'AFy9TccbpVIPGGtxbD0pMil3P3E+Pbz7OYioFq0sBHhWq3WXwcS+yq4JCcWCKVtj2Q==', N'd37d1149-9530-439b-8a56-543fe7af08d2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d36ca88-03da-434e-9c58-4e35db7bbb5d', N'guest@vidly.com', 0, N'ADiRGQYWW0NNa8udT1Kxv9h4eV+rAlbBgig2QZGMcFSZrvoXip+ldn6EVKaqLw+lVw==', N'517d240c-d270-48be-b6bb-a9cff822dd73', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8dd83f5a-152a-408b-ac32-2f15d3d0fa18', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'307c993b-8952-4f46-97db-58a4ae226814', N'8dd83f5a-152a-408b-ac32-2f15d3d0fa18')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
