namespace ResturantUsingMvcEtLts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateWaitersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Waiters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birth = c.String(),
                        WorkingHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Waiters");
        }
    }
}
