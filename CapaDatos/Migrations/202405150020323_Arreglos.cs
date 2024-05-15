namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Arreglos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DetallesDeVentas", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DetallesDeVentas", "Precio", c => c.Int(nullable: false));
        }
    }
}
