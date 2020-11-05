namespace CODEFIRST_MIGRATIONS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_novos_campos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FILMEs", "ANOLANCAMENTO", c => c.Int(nullable: false));
            AddColumn("dbo.NOTAFILMEs", "DATACADASTRO", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NOTAFILMEs", "DATACADASTRO");
            DropColumn("dbo.FILMEs", "ANOLANCAMENTO");
        }
    }
}
