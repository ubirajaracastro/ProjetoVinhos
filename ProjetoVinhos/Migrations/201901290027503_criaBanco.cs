namespace ProjetoVinhos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criaBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vinhos",
                c => new
                    {
                        cod_vinho = c.Int(nullable: false, identity: true),
                        nome_vinho = c.String(nullable: false, maxLength: 100, unicode: false),
                        idade_vinho = c.Int(nullable: false),
                        preco_vinho = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.cod_vinho);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vinhos");
        }
    }
}
