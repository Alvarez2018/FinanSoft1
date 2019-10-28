namespace FinanSoft.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionArticulo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articulos");
        }
    }
}
