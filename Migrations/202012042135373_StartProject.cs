namespace ProyectoPostres.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre_Postre = c.String(),
                        Ingredientes = c.String(),
                        Receta_Postre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Recetas");
        }
    }
}
