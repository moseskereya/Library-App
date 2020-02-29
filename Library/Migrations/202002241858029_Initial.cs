namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Book", "Title", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Book", "Author", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book", "Author", c => c.String());
            AlterColumn("dbo.Book", "Title", c => c.String());
        }
    }
}
