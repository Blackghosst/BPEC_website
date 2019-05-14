namespace BPEC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PageContent",
                c => new
                    {
                        PageContentID = c.Int(nullable: false, identity: true),
                        PageCode = c.String(),
                        PageContentHTML = c.String(),
                        LastUpdatedBy = c.String(),
                        LasyUpdatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PageContentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PageContent");
        }
    }
}
