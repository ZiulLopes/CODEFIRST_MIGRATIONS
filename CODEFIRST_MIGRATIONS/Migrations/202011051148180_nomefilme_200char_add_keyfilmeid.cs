namespace CODEFIRST_MIGRATIONS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nomefilme_200char_add_keyfilmeid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FILMEs", "NOMEFILME", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FILMEs", "NOMEFILME", c => c.String());
        }
    }
}
