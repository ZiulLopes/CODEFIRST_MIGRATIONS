namespace CODEFIRST_MIGRATIONS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primeira_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FILMEs",
                c => new
                    {
                        FILMEID = c.Int(nullable: false, identity: true),
                        NOMEFILME = c.String(),
                    })
                .PrimaryKey(t => t.FILMEID);
            
            CreateTable(
                "dbo.NOTAFILMEs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NOTAVALOR = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NOTAFILMEs");
            DropTable("dbo.FILMEs");
        }
    }
}
